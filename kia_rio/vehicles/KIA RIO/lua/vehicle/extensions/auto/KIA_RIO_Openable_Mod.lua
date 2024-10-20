------ Variables ------
local M = {}
local modAttached = false
local override = false

------ Functions ------
local function has_value(nTable, nValue)
    for index, value in pairs(nTable) do
        if value == nValue then
            print(index)
            return true
        end
    end
    return false
end

local function CloseParts()
    electrics.values['trunk'] = 0
    electrics.values['hood'] = 0
    electrics.values['doorFL'] = 0
    electrics.values['doorFR'] = 0
    electrics.values['doorRL'] = 0
    electrics.values['doorRR'] = 0
end

local function getNodeID(name)
    local nodeID = nil
    for k, node in pairs(v.data.nodes) do
        if tostring(node.name) == tostring(name) then
            return node.cid
        end
    end
    return null
end

local function AdjustSpringStrength(node1, node2, strength)

    node1 = getNodeID(node1)
    node2 = getNodeID(node2)

    for k, beam in pairs(v.data.beams) do
        if (beam.id1 == node1 and beam.id2 == node2) or (beam.id2 == node1 and beam.id1 == node2) then

            beam.beamDamp = strength
            beam.beamSpring = strength

            obj:setBeamSpringDamp(beam.cid, beam.beamSpring, beam.beamDamp, -1, -1)

        end
    end
end

local function BreakBeamFromNodes(node1, node2)
    for k, beam in pairs(v.data.beams) do
        if string.find(tostring(beam.breakGroup), "_Openable") == nil then
            if beam.id1 == node1 and beam.id2 == node2 then
                obj:breakBeam(k)
            end
            if beam.id2 == node1 and beam.id1 == node2 then
                obj:breakBeam(k)
            end
        end
    end
end

local function removeNodeCollision(node)

    local NORMALTYPE = 0
    local NODE_FIXED = 1

    local ntype = NORMALTYPE
    if node.fixed == true then
        ntype = NODE_FIXED
    end

    local collision
    if node.collision ~= nil then
        collision = node.collision
    else
        collision = true
    end

    local selfCollision
    if node.selfCollision ~= nil then
        selfCollision = node.selfCollision
    else
        selfCollision = false
    end

    local staticCollision
    if node.staticCollision ~= nil then
        staticCollision = node.staticCollision
    else
        staticCollision = true
    end

    local frictionCoef = type(node.frictionCoef) == 'number' and node.frictionCoef or 1
    local slidingFrictionCoef = type(node.slidingFrictionCoef) == 'number' and node.slidingFrictionCoef or frictionCoef
    local noLoadCoef = type(node.noLoadCoef) == 'number' and node.noLoadCoef or 1
    local fullLoadCoef = type(node.fullLoadCoef) == 'number' and node.fullLoadCoef or 0
    local loadSensitivitySlope = type(node.loadSensitivitySlope) == 'number' and node.loadSensitivitySlope or 0

    local nodeWeight = node.nodeWeight or 0

    local nodeMaterialTypeID
    if node.nodeMaterial ~= nil then
        nodeMaterialTypeID = node.nodeMaterial
        if type(nodeMaterialTypeID) ~= "number" then
            log_jbeam('D', "jbeam.pushToPhysics", "invalid node material id:" .. tostring(nodeMaterialTypeID))
            nodeMaterialTypeID = 0
        end
    else
        nodeMaterialTypeID = 0
    end

    local pos = vec3(obj:getNodePosition(node.cid))
    obj:setNode(node.cid, pos.x, pos.y, pos.z, nodeWeight, ntype, frictionCoef, slidingFrictionCoef,
        node.stribeckExponent or 1.75, node.stribeckVelMult or 1, noLoadCoef, fullLoadCoef, loadSensitivitySlope,
        node.softnessCoef or 0.5, node.treadCoef or 0.5, node.tag or '', node.couplerStrength or math.huge,
        node.firstGroup or -1, false, collision, staticCollision, nodeMaterialTypeID)
end

local function breakConnectingBeams() -- searches for and breaks beams
    CloseParts()
    for k, beam in pairs(v.data.beams) do -- loop for each beam 
        if (string.find(tostring(beam.breakGroup), "_Openable") ~= nil) then
            modAttached = true
        end

        if beam.breakGroup ~= nil and beam.breakGroup ~= "" then -- if beam contains a breakGroup
            ------ All vehicles ------
            if string.find(tostring(beam.breakGroup), "hoodlatch") ~= nil or -- if beam is for the hood
                string.find(tostring(beam.breakGroup), "tailgatelatch") ~= nil or -- or if beam is for the tailgate
                string.find(tostring(beam.breakGroup), "trunklatch") ~= nil or -- or if beam is for the trunk
                string.find(tostring(beam.breakGroup), "doorlatch") ~= nil then -- or if beam is for a door
                if string.find(tostring(beam.breakGroup), "_Openable") == nil then -- if beam hasnt be added by this mod
                    if (modAttached or override) then
                        obj:breakBeam(k) -- breaks beam
                    end
                end
            end

            ------ Wendover ------
            if string.find(tostring(v.data.options.partName), "wendover") then
                if string.find(tostring(beam.breakGroupType), "1") ~= nil and
                    string.find(tostring(beam.breakGroup), "hoodhinge") then
                    if string.find(tostring(beam.breakGroup), "_Openable") == nil then -- if beam hasnt be added by this mod
                        if (modAttached or override) then
                            obj:breakBeam(k) -- breaks beam
                        end
                    end
                end
                if string.find(tostring(beam.beamType), "BOUNDED") ~= nil and
                    string.find(tostring(beam.breakGroup), "hoodhinge") then
                    if string.find(tostring(beam.breakGroup), "_Openable") == nil then -- if beam hasnt be added by this mod
                        if (modAttached or override) then
                            obj:breakBeam(k) -- breaks beam
                        end
                    end
                end
            end

            ------ Vivace ------
            if string.find(tostring(v.data.options.partName), "vivace") then
                if string.find(tostring(beam.breakGroup), "latch") ~= nil then
                    -- string.find(tostring(beam.breakGroup), "tailgatehinge") ~= nil then
                    if string.find(tostring(beam.breakGroup), "_Openable") == nil then
                        if (modAttached or override) then
                            obj:breakBeam(k)
                        end
                    end
                end
            end
        end
    end

    if (modAttached) then
        local n = {}

        ------ 200BX ------
        if string.find(tostring(v.data.options.partName), "coupe") then
            ------ Disable node self colisions ------
            ------ FL Door ------
            n[0] = getNodeID('d4l')
            ------ FR Door ------
            n[1] = getNodeID('d4r')

            ------ prevent windows from breaking------
            ------ FL Door ------
            AdjustSpringStrength('d7l', 'd8l', 0)
            AdjustSpringStrength('d7l', 'd9l', 0)
            AdjustSpringStrength('d7l', 'd10l', 0)
            AdjustSpringStrength('d7l', 'd11l', 0)
            AdjustSpringStrength('d7l', 'd12l', 0)
            AdjustSpringStrength('d7l', 'd13l', 0)
            ------ FR Door ------
            AdjustSpringStrength('d7r', 'd8r', 0)
            AdjustSpringStrength('d7r', 'd9r', 0)
            AdjustSpringStrength('d7r', 'd10r', 0)
            AdjustSpringStrength('d7r', 'd11r', 0)
            AdjustSpringStrength('d7r', 'd12r', 0)
            AdjustSpringStrength('d7r', 'd13r', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h5'))
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('f15r'), getNodeID('h5r'))
            BreakBeamFromNodes(getNodeID('f15l'), getNodeID('h5l'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h5l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h5r'))
        end

        ------ Vivace ------
        if string.find(tostring(v.data.options.partName), "vivace") then
            ------ Disable node self colisions ------
            ------ Tailgate ------
            n[0] = getNodeID('t5ll')
            n[1] = getNodeID('t5rr')

            n[2] = getNodeID('t1')
            n[3] = getNodeID('t1l')
            n[4] = getNodeID('t1r')

            ------ removing default pop open beams ------
            BreakBeamFromNodes(getNodeID('t3rr'), getNodeID('r3rr'))
            BreakBeamFromNodes(getNodeID('t3ll'), getNodeID('r3ll'))
            ------ removing default tailgate strings ------
            BreakBeamFromNodes(getNodeID('sh2l'), getNodeID('t3ll'))
            BreakBeamFromNodes(getNodeID('sh2r'), getNodeID('t3rr'))
            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('rb2'), getNodeID('t5'))
        end

        ------ KIA RIO ------
        if string.find(tostring(v.data.options.partName), "KIA RIO") then
            ------ Disable node self colisions ------
            ------ FL Door ------
            n[0] = getNodeID('d4l')
            n[1] = getNodeID('d7l')
            ------ FR Door ------
            n[3] = getNodeID('d4r')
            n[4] = getNodeID('d7r')
            ------ RL Door ------
            n[2] = getNodeID('d17l')
            ------ RR Door ------
            n[5] = getNodeID('d17r')

            ------ prevent windows from breaking------
            ------ FL Door ------
            AdjustSpringStrength('d7l', 'd8l', 0)
            AdjustSpringStrength('d7l', 'd9l', 0)
            AdjustSpringStrength('d7l', 'd10l', 0)
            AdjustSpringStrength('d7l', 'd11l', 0)
            AdjustSpringStrength('d7l', 'd12l', 0)
            AdjustSpringStrength('d7l', 'd13l', 0)
            ------ FR Door ------
            AdjustSpringStrength('d7r', 'd8r', 0)
            AdjustSpringStrength('d7r', 'd9r', 0)
            AdjustSpringStrength('d7r', 'd10r', 0)
            AdjustSpringStrength('d7r', 'd11r', 0)
            AdjustSpringStrength('d7r', 'd12r', 0)
            AdjustSpringStrength('d7r', 'd13r', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he3l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he3r'))
            BreakBeamFromNodes(getNodeID('p11l'), getNodeID('t3ll'))
            BreakBeamFromNodes(getNodeID('p11r'), getNodeID('t3rr'))
        end

        ------ Grand Marshal ------
        if string.find(tostring(v.data.options.partName), "fullsize") then
            ------ Disable node self colisions ------
            ------ Hood ------
            n[0] = getNodeID('h5')

            ------ prevent windows from breaking------
            ------ FL Door ------
            AdjustSpringStrength('d7l', 'd8l', 0)
            AdjustSpringStrength('d7l', 'd9l', 0)
            AdjustSpringStrength('d7l', 'd10l', 0)
            AdjustSpringStrength('d7l', 'd11l', 0)
            AdjustSpringStrength('d7l', 'd12l', 0)
            AdjustSpringStrength('d7l', 'd13l', 0)
            ------ FR Door ------
            AdjustSpringStrength('d7r', 'd8r', 0)
            AdjustSpringStrength('d7r', 'd9r', 0)
            AdjustSpringStrength('d7r', 'd10r', 0)
            AdjustSpringStrength('d7r', 'd11r', 0)
            AdjustSpringStrength('d7r', 'd12r', 0)
            AdjustSpringStrength('d7r', 'd13r', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he3l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he3r'))
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he5l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he5r'))
        end

        ------ Covet ------
        if string.find(tostring(v.data.options.partName), "hatch") then
            ------ Disable node self colisions ------
            ------ FL Door ------
            n[0] = getNodeID('d1l')
            n[1] = getNodeID('d4l')
            n[2] = getNodeID('d7l')
            ------ FR Door ------
            n[3] = getNodeID('d1r')
            n[4] = getNodeID('d4r')
            n[5] = getNodeID('d7r')

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('t4rr'), getNodeID('tl2r'))
            BreakBeamFromNodes(getNodeID('t4ll'), getNodeID('tl2l'))
            BreakBeamFromNodes(getNodeID('t4r'), getNodeID('tl4r'))
            BreakBeamFromNodes(getNodeID('t4l'), getNodeID('tl4l'))
            BreakBeamFromNodes(getNodeID('f14rr'), getNodeID('h2rr'))
            BreakBeamFromNodes(getNodeID('f14ll'), getNodeID('h2ll'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he1r'))
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he1l'))
        end

        ------ Legran ------
        if string.find(tostring(v.data.options.partName), "legran") then
            ------ Disable node self colisions ------
            ------ FL Door ------
            n[0] = getNodeID('d1l')
            n[1] = getNodeID('d4l')
            n[2] = getNodeID('d7l')
            ------ FR Door ------
            n[3] = getNodeID('d1r')
            n[4] = getNodeID('d4r')
            n[5] = getNodeID('d7r')
            ------ RL Door ------
            n[6] = getNodeID('d15l')
            n[7] = getNodeID('d18l')
            n[8] = getNodeID('d21l')
            ------ RR Door ------
            n[9] = getNodeID('d15r')
            n[10] = getNodeID('d18r')
            n[11] = getNodeID('d21r')
            ------ Wagon Tailgate ------
            n[12] = getNodeID('tl3l')
            n[13] = getNodeID('tl3r')
            n[14] = getNodeID('t4')
            n[15] = getNodeID('t4l')
            n[16] = getNodeID('t4r')
            n[17] = getNodeID('t4ll')
            n[18] = getNodeID('t4rr')

            ------ prevent windows from breaking------
            ------ FL Door ------
            AdjustSpringStrength('d7l', 'd8l', 0)
            AdjustSpringStrength('d7l', 'd9l', 0)
            AdjustSpringStrength('d7l', 'd10l', 0)
            AdjustSpringStrength('d7l', 'd11l', 0)
            AdjustSpringStrength('d7l', 'd12l', 0)
            AdjustSpringStrength('d7l', 'd13l', 0)
            ------ FR Door ------
            AdjustSpringStrength('d7r', 'd8r', 0)
            AdjustSpringStrength('d7r', 'd9r', 0)
            AdjustSpringStrength('d7r', 'd10r', 0)
            AdjustSpringStrength('d7r', 'd11r', 0)
            AdjustSpringStrength('d7r', 'd12r', 0)
            AdjustSpringStrength('d7r', 'd13r', 0)

            ------ Removing default pop open beams ------
            ------ Sedan ------
            AdjustSpringStrength('t3l', 'r8ll', 0)
            AdjustSpringStrength('t3r', 'r8rr', 0)
            ------ Wagon ------
            AdjustSpringStrength('t3ll', 'r3ll', 0)
            AdjustSpringStrength('t3rr', 'r3rr', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('d18l'), getNodeID('f8l'))
            BreakBeamFromNodes(getNodeID('d18r'), getNodeID('f8r'))
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h4'))
        end

        ------ Pessima MK2 ------
        if string.find(tostring(v.data.options.partName), "midsize") then
            ------ Disable node self colisions ------
            ------ FL Door ------
            n[0] = getNodeID('d1l')
            n[1] = getNodeID('d4l')
            n[2] = getNodeID('d7l')
            ------ FR Door ------
            n[3] = getNodeID('d1r')
            n[4] = getNodeID('d4r')
            n[5] = getNodeID('d7r')

            ------ Removing default pop open beams (Wagon mods) ------
            AdjustSpringStrength('t3l', 'r7ll', 0)
            AdjustSpringStrength('t3r', 'r7rr', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('g1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('g1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('g1r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he1l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he1r'))
            BreakBeamFromNodes(getNodeID('fb1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('fb1'), getNodeID('h5'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h5l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h5r'))
            BreakBeamFromNodes(getNodeID('fb2'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('fe12l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('fe12r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('fe12l'), getNodeID('h4ll'))
            BreakBeamFromNodes(getNodeID('fe12r'), getNodeID('h4rr'))
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h5'))
            BreakBeamFromNodes(getNodeID('f15l'), getNodeID('h5l'))
            BreakBeamFromNodes(getNodeID('f15r'), getNodeID('h5r'))
        end

        ------ Pessima MK1 ------
        if string.find(tostring(v.data.options.partName), "pessima") then
            ------ prevent windows from breaking------
            ------ FL Door ------
            AdjustSpringStrength('d7l', 'd8l', 0)
            AdjustSpringStrength('d7l', 'd9l', 0)
            AdjustSpringStrength('d7l', 'd10l', 0)
            AdjustSpringStrength('d7l', 'd11l', 0)
            AdjustSpringStrength('d7l', 'd12l', 0)
            AdjustSpringStrength('d7l', 'd13l', 0)
            ------ FR Door ------
            AdjustSpringStrength('d7r', 'd8r', 0)
            AdjustSpringStrength('d7r', 'd9r', 0)
            AdjustSpringStrength('d7r', 'd10r', 0)
            AdjustSpringStrength('d7r', 'd11r', 0)
            AdjustSpringStrength('d7r', 'd12r', 0)
            AdjustSpringStrength('d7r', 'd13r', 0)

            ------ Removing default pop open beams (LJ's Wagon) ------
            AdjustSpringStrength('t3ll', 'r3ll', 0)
            AdjustSpringStrength('t3rr', 'r3rr', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('g1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('g1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('g1r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he1l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he1r'))
            BreakBeamFromNodes(getNodeID('fb1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h4r'))
        end

        ------ SBR4 ------
        if string.find(tostring(v.data.options.partName), "sbr") then
            ------ Disable node self colisions ------
            ------ Hood ------
            n[0] = getNodeID('he1l')
            n[1] = getNodeID('he1r')

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('f11ll'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('f11rr'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('fb1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h4ll'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h4rr'))
            BreakBeamFromNodes(getNodeID('t4ll'), getNodeID('tl2l'))
            BreakBeamFromNodes(getNodeID('t4rr'), getNodeID('tl2r'))
            BreakBeamFromNodes(getNodeID('t4l'), getNodeID('tl1l'))
            BreakBeamFromNodes(getNodeID('t4r'), getNodeID('tl1r'))

        end

        ------ Sunburst ------
        if string.find(tostring(v.data.options.partName), "sunburst") then
            ------ Disable node self colisions ------
            ------ Tailgate ------
            n[0] = getNodeID('tl1l')
            n[1] = getNodeID('tl3l')
            n[2] = getNodeID('tl1r')
            n[3] = getNodeID('tl3r')
            n[4] = getNodeID('rb1l')
            n[5] = getNodeID('rb1r')

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('fb1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('fb1'), getNodeID('h5'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h5l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h5r'))
            BreakBeamFromNodes(getNodeID('fb1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('fb1r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('f15l'), getNodeID('h5l'))
            BreakBeamFromNodes(getNodeID('f15r'), getNodeID('h5r'))
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he3l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he3r'))
        end

        ------ Bolide ------
        if string.find(tostring(v.data.options.partName), "super") then
            ------ Disable node self colisions ------
            ------ Hood ------
            n[0] = getNodeID('h1l')
            n[1] = getNodeID('h1')
            n[2] = getNodeID('h1r')
            n[3] = getNodeID('fi1l')
            n[4] = getNodeID('fi1')
            n[5] = getNodeID('fi1r')
            ------ FL Door ------
            n[6] = getNodeID('d1l')
            n[7] = getNodeID('d4l')
            n[8] = getNodeID('d7l')
            ------ FR Door ------
            n[9] = getNodeID('d1r')
            n[10] = getNodeID('d4r')
            n[11] = getNodeID('d7r')

            ------ Break beams that restrict opening ------
            ------ Hood ------
            BreakBeamFromNodes(getNodeID('fi1l'), getNodeID('h1'))
            BreakBeamFromNodes(getNodeID('fi1r'), getNodeID('h1'))
            BreakBeamFromNodes(getNodeID('h1l'), getNodeID('c2l'))
            BreakBeamFromNodes(getNodeID('h1r'), getNodeID('c2r'))
        end

        ------ EKTI ------
        if string.find(tostring(v.data.options.partName), "KIA RIO") then
            ------ Disable node self colisions ------
            ------ FL Door ------
            n[0] = getNodeID('d1l')
            n[1] = getNodeID('d4l')
            n[2] = getNodeID('d7l')
            ------ FR Door ------
            n[3] = getNodeID('d1r')
            n[4] = getNodeID('d4r')
            n[5] = getNodeID('d7r')
            ------ RL Door ------
            n[6] = getNodeID('d17l')
            ------ RR Door ------
            n[7] = getNodeID('d17r')

            ------ Prevent windows from breaking------
            ------ FL Door ------
            AdjustSpringStrength('d7l', 'd8l', 0)
            AdjustSpringStrength('d7l', 'd9l', 0)
            AdjustSpringStrength('d7l', 'd10l', 0)
            AdjustSpringStrength('d7l', 'd11l', 0)
            AdjustSpringStrength('d7l', 'd12l', 0)
            AdjustSpringStrength('d7l', 'd13l', 0)
            ------ FR Door ------
            AdjustSpringStrength('d7r', 'd8r', 0)
            AdjustSpringStrength('d7r', 'd9r', 0)
            AdjustSpringStrength('d7r', 'd10r', 0)
            AdjustSpringStrength('d7r', 'd11r', 0)
            AdjustSpringStrength('d7r', 'd12r', 0)
            AdjustSpringStrength('d7r', 'd13r', 0)

            ------ Breaking extra beams (beams which either restrict opening or break anyway) ------
            BreakBeamFromNodes(getNodeID('g1'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('g1r'), getNodeID('h4r'))
            BreakBeamFromNodes(getNodeID('g1l'), getNodeID('h4l'))
            BreakBeamFromNodes(getNodeID('f15'), getNodeID('h4'))
            BreakBeamFromNodes(getNodeID('h4l'), getNodeID('he1l'))
            BreakBeamFromNodes(getNodeID('h4r'), getNodeID('he1r'))
        end

        ------ Wendover ------
        if string.find(tostring(v.data.options.partName), "wendover") then
            ------ Removing default pop open beams ------
            AdjustSpringStrength('t3l', 'r8ll', 0)
            AdjustSpringStrength('t3r', 'r8rr', 0)
        end

        ------ Removing node self colisions ------
        for k, node in pairs(v.data.nodes) do
            if has_value(n, k) then
                removeNodeCollision(node)
            end
        end
    end
end

function OpenPart(node1, node2, originalSpring, openValue)
    node1 = getNodeID(node1)
    node2 = getNodeID(node2)

    if originalSpring == 0 then
        originalSpring = 2000000
    end

    for k, beam in pairs(v.data.beams) do
        if beam.beamPrecompression == 1 and string.find(tostring(beam.breakGroup), "_Openable") ~= nil then
            if (beam.id1 == node1 and beam.id2 == node2) or (beam.id2 == node1 and beam.id1 == node2) then

                if openValue ~= 0 then
                    beam.beamSpring = 0
                    beam.beamDamp = 0
                else
                    beam.beamSpring = originalSpring
                    beam.beamDamp = 10
                end

                obj:setBeamSpringDamp(beam.cid, beam.beamSpring, beam.beamDamp, -1, -1)

            end
        end
    end
end

M.onReset = breakConnectingBeams
M.onInit = CloseParts
return M
