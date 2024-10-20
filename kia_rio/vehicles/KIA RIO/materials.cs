
singleton Material(GR_Rio_windshield_dmg)
{
    mapTo = "GR_Rio_windshield_dmg";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/windshield_dmg_n.dds";
    diffuseColor[0] = "0.180619001 0.180617005 0.180617005 0.00800000038";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   colorMap[0] = "vehicles/etki/etki_glass_dmg_d.dds";
   pixelSpecular[0] = "1";
   roughnessFactor[0] = "0.126778603";
};

singleton Material(GR_Rio_glass_dmg)
{
    mapTo = "GR_Rio_glass_dmg";
    opacityMap[0] = "vehicles/etki/etki_glass_dmg_d.dds";
    diffuseColor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07 0.0410000011";
    diffuseColor[1] = "0 0 0 0.0160000008";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   roughnessFactor[0] = "0.445299804";
   roughnessFactor[1] = "0.445299804";
};

singleton Material(KIA_RIO_GRmm_plastics__spec_)
{
   mapTo = "GRmm_plastics__spec_";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.684000015";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.234913006 0.234915003 0.234915003 1";
   metallicFactor[0] = "0.781000018";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_GrMM_Stop)
{
   mapTo = "GrMM_Stop";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.71864599 0 0.0727199987 1";
   metallicFactor[0] = "0.587000012";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Grmm_radiator)
{
   mapTo = "Grmm_radiator";
   specular[0] = "0.5 0.5 0.5 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Podveska_n.dds";
   normalMapStrength[0] = "5";
   roughnessFactor[0] = "0.718999982";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Podveska_s_alt.dds";
   baseColorFactor[0] = "0.965448022 0.965438008 0.965438008 1";
   metallicMap[0] = "/vehicles/KIA RIO/TXT/Podveska_s_alt.dds";
   roughnessMap[0] = "/vehicles/KIA RIO/TXT/Podveska_s.dds";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   opacityMap[0] = "/vehicles/KIA RIO/TXT/Podveska_d_alt.dds";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Grmm_vehicle_generic_glasswindows2__env_2_spec_trans_)
{
   mapTo = "Grmm_vehicle_generic_glasswindows2__env_2_spec_trans_";
   specular[0] = "0.0078125 0.0078125 0.0078125 1";
   doubleSided = "0";
   translucentBlendOp = "PreMulAlpha";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.531075001 0.531077027 0.531072021 0";
   opacityFactor[0] = "0.157000005";
   metallicFactor[0] = "0.300999999";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   translucent = "1";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Grmm_strykerbed__spec_)
{
   mapTo = "Grmm_strykerbed__spec_";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.644401252";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/strykerbed.png";
   baseColorFactor[0] = "0.387932003 0.387928009 0.387928009 1";
   metallicFactor[0] = "0.65200001";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Plastick_engine)
{
   mapTo = "Plastick_engine";
   specular[0] = "0.5 0.5 0.5 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.449999988";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.531077027 0.531072021 0.531072021 1";
   metallicFactor[0] = "0.294";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_GRm_Rio)
{
   mapTo = "GRm_Rio";
   specular[0] = "0 0 0 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.50999999";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Podveska_d_alt.dds";
   baseColorFactor[0] = "1 0.999989986 0.999989986 1";
   metallicMap[0] = "/vehicles/KIA RIO/TXT/Podveska_s.dds";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Podveska_n.dds";
   normalMapStrength[0] = "3";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
};

singleton Material(KIA_RIO_GRmm_remap__prim_env_14_spec_)
{
   mapTo = "GRmm_remap__prim_env_14_spec_";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.999989986 0.999992013 1";
   metallicFactor[0] = "1";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   colorPaletteMap[0] = "/vehicles/KIA RIO/PBR/Pallete1.png";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/PBR/main_n.normal.DDS";
   emissiveFactor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07";
};

singleton Material(KIA_RIO_grm_Crom)
{
   mapTo = "grm_Crom";
   specular[0] = "0.0078125 0.0078125 0.0078125 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.999989986 0.999989986 0.0720259994";
   metallicFactor[0] = "0.841000021";
   clearCoatFactor[0] = "0";
   clearCoatRoughnessFactor[0] = "1";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/PBR/main_n.normal.DDS";
   emissiveFactor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07";
   opacityFactor[0] = "1";
};

singleton Material(KIA_RIO_pessima_engine)
{
   mapTo = "pessima_engine";
   diffuseColor[0] = "0.154141 0.154141 0.154141 1";
   specular[0] = "0 0 0 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(KIA_RIO_Grm_Povorot__R)
{
   mapTo = "Grm_Povorot__R";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.108999997";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.999996006 0.999989986 1";
   metallicFactor[0] = "0.878000021";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
};

singleton Material(KIA_RIO_Grmm_Zad_Fara)
{
   mapTo = "Grmm_Zad_Fara";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "0";
   translucentBlendOp = "PreMulAlpha";
   roughnessFactor[0] = "0";
   version = "1.5";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.466908991 0 0 1";
   metallicFactor[0] = "1";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
   opacityFactor[0] = "0.572000027";
   translucent = "1";
};

singleton Material(KIA_RIO_Grmm_Zad_Fara)
{
   mapTo = "Grmm_Zad_Fara";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "0";
   translucentBlendOp = "LerpAlpha";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.693965971 0 0 1";
   opacityFactor[0] = "0.699000001";
   metallicFactor[0] = "1";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   translucent = "1";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_GrMM_zada_hod)
{
   mapTo = "GrMM_zada_hod";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.999989986 0.999989986 1";
   metallicFactor[0] = "1";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Grmm_Zad_Fara)
{
   mapTo = "Grmm_Zad_Fara";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "0";
   translucentBlendOp = "PreMulAlpha";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.703837991 0 0 1";
   opacityFactor[0] = "0.763999999";
   metallicFactor[0] = "0.813000023";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   translucent = "1";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Grm_Povorot_L)
{
   mapTo = "Grm_Povorot_L";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.99999398 0.999989986 1";
   metallicFactor[0] = "0.878000021";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
};

singleton Material(KIA_RIO_Grmm_black_plastik__spec_)
{
   mapTo = "Grmm_black_plastik__spec_";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.551999986";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/torpedo_leather.png";
   baseColorFactor[0] = "0.866726995 0.866719007 0.866719007 1";
   metallicFactor[0] = "0.437999994";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/torpedo_leather_norm.png";
};

singleton Material(KIA_RIO_Grmm_BLIJ)
{
   mapTo = "Grmm_BLIJ";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.999989986 0.999989986 0.0868349969";
   dynamicCubemap = "1";
   opacityFactor[0] = "0";
   metallicFactor[0] = "0.902999997";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
   normalMapStrength[0] = "-0.5";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   detailMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
};

singleton Material(KIA_RIO_Grmm_BLIJ)
{
   mapTo = "Grmm_BLIJ";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.999989986 0.999989986 0.0868349969";
   metallicFactor[0] = "0.888000011";
   dynamicCubemap = "1";
   opacityFactor[0] = "0";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
   detailMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   normalMapStrength[0] = "-0.5";
};

singleton Material(KIA_RIO_speed)
{
   mapTo = "speed";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.935000002";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/2123.png";
   baseColorFactor[0] = "0.950640023 0.950630009 0.950630009 1";
   opacityFactor[0] = "0.750999987";
   metallicFactor[0] = "0.948000014";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_speed_on)
{
   mapTo = "speed_on";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1";
   roughnessFactor[0] = "0.550000012";
   dynamicCubemap = "0";
   diffuseColor[0] = "0.891407013 0.808669984 0.697807014 1";
   colorMap[0] = "/vehicles/KIA RIO/TXT/2123.png";
   emissive[0] = "1";
};

singleton Material(KIA_RIO_plastic)
{
   mapTo = "plastic";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.388000011";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.308955997 0.308952987 0.308952987 1";
   metallicFactor[0] = "0.856000006";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_GR_Rio_dno)
{
   mapTo = "GR_Rio_dno";
   specular[0] = "0.5 0.5 0.5 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.535000026";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Rio_s.dds";
   baseColorFactor[0] = "0.274403989 0.274401009 0.274401009 0.0127940001";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Rio_n.dds";
   normalMapStrength[0] = "3";
   opacityFactor[0] = "0.815999985";
   metallicFactor[0] = "0.783999979";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   metallicMap[0] = "/vehicles/KIA RIO/TXT/Rio_d.dds";
};


singleton Material(KIA_RIO_Grmm_005kiario)
{
   mapTo = "Grmm_005kiario";
   version = "1.5";
   roughnessFactor[0] = "0.902999997";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.555751979 0.555755973 0.555756986 1";
   metallicFactor[0] = "1";
   clearCoatFactor[0] = "0";
   clearCoatRoughnessFactor[0] = "1";
   specular[0] = "0.0078125 0.0078125 0.0078125 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
   normalMapStrength[0] = "15";
   opacityFactor[0] = "0.907999992";
};

singleton Material(KIA_RIO_rio_engine)
{
   mapTo = "rio_engine";
   diffuseColor[0] = "0.0299278 0.0299278 0.0299278 1";
   specular[0] = "0.000976562 0.000976562 0.000976562 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(KIA_RIO_Matte__FF666666__env_50_spec_)
{
   mapTo = "Matte__FF666666__env_50_spec_";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.611999989";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.595246017 0.595239997 0.595239997 1";
   metallicFactor[0] = "0.684000015";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Matte__FF999999__env_50_spec_)
{
   mapTo = "Matte__FF999999__env_50_spec_";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.402999997";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.837110996 0.837103009 0.837103009 1";
   metallicFactor[0] = "0.82099998";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Mafon_grmm)
{
   mapTo = "Mafon_grmm";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
   normalMapStrength[0] = "5";
   roughnessFactor[0] = "0.750999987";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/2005kiario.png";
   baseColorFactor[0] = "0.723582029 0.723574996 0.723574996 1";
   metallicFactor[0] = "0.681999981";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_pessima_engine)
{
   mapTo = "pessima_engine";
   diffuseColor[0] = "0.154141 0.154141 0.154141 1";
   specular[0] = "0 0 0 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(KIA_RIO_GRmm_exhaust)
{
   mapTo = "GRmm_exhaust";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Rio_engine_n.dds";
   normalMapStrength[0] = "5";
   roughnessFactor[0] = "0.381000012";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Rio_engine_s.dds";
   baseColorFactor[0] = "0.639999986 0.639999986 0.639999986 1";
   metallicMap[0] = "/vehicles/KIA RIO/TXT/Rio_engine_d.dds";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_GFrmm_setka)
{
   mapTo = "GFrmm_setka";
   translucentBlendOp = "PreMulAlpha";
   version = "1.5";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Setka.png";
   baseColorFactor[0] = "0.689029992 0.689023018 0.689023018 1";
   translucent = "1";
   dynamicCubemap = "1";
   metallicFactor[0] = "1";
};

singleton Material(KIA_RIO_Speed_strela)
{
   mapTo = "Speed_strela";
   translucentBlendOp = "None";
   version = "1.5";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.921024024 0.272771001 0 1";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Speed_strela_on)
{
   mapTo = "Speed_strela_on";
   translucentBlendOp = "None";
   version = "1";
   dynamicCubemap = "0";
   diffuseColor[0] = "1 0.0592320003 0 1";
   colorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   glow[0] = "1";
   emissive[0] = "1";
};

singleton Material(KIA_RIO_Plast_salona_Gr)
{
   mapTo = "Plast_salona_Gr";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.691999972";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.234915003 0.234913006 0.234913006 1";
   metallicFactor[0] = "0.579999983";
   dynamicCubemap = "1";
   opacityFactor[0] = "0.703999996";
};

singleton Material(KIA_RIO_KiaRio_interior)
{
   mapTo = "KiaRio_interior";
   specular[0] = "0.5 0.5 0.5 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Rio_interior_n.dds";
   normalMapStrength[0] = "5";
   roughnessFactor[0] = "0.524999976";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Rio_interior_d.dds";
   baseColorFactor[0] = "0.916087985 0.916077971 0.916077971 1";
   metallicFactor[0] = "0.372999996";
   roughnessMap[0] = "/vehicles/KIA RIO/TXT/Rio_interior_b.color.DDS";
   metallicMap[0] = "/vehicles/KIA RIO/TXT/Rio_interior_ao.data.DDS";
};

singleton Material(KIA_RIO_Ria_seats)
{
   mapTo = "Ria_seats";
   specular[0] = "0.5 0.5 0.5 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Rio_seats_n.dds";
   normalMapStrength[0] = "2";
   roughnessFactor[0] = "0.84799999";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Rio_seats_b.color.DDS";
   baseColorFactor[0] = "0.807494998 0.807487011 0.807487011 1";
   metallicMap[0] = "/vehicles/KIA RIO/TXT/Rio_seats_d.dds";
   metallicFactor[0] = "0.218999997";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Tum_ria)
{
   mapTo = "Tum_ria";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.173999995";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.664349973 0.664342999 0.664342999 1";
   metallicFactor[0] = "0.726000011";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
   normalMap[0] = "/vehicles/KIA RIO/TXT/Tuman_norm.png";
   normalMapStrength[0] = "0.5";
};

singleton Material(KIA_RIO_Orange_fara_L)
{
   mapTo = "Orange_fara_L";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/TXT/2005kiario_norm.png";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.521569014 0.043136999 1";
   metallicFactor[0] = "0.927999973";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Orange_Frara_R)
{
   mapTo = "Orange_Frara_R";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "1 0.521203995 0.0424100012 1";
   metallicFactor[0] = "0.927999973";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_rim__spec_)
{
   mapTo = "rim__spec_";
   translucentBlendOp = "None";
   version = "1.5";
   normalMap[0] = "/vehicles/KIA RIO/PBR/main_n.normal.DDS";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.960511982 0.676476002 0.310979009 0.244788006";
   metallicFactor[0] = "0.423000008";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Matte__FF000000__spec_)
{
   mapTo = "Matte__FF000000__spec_";
   diffuseColor[0] = "0.00326151 0.00326151 0.00326151 1";
   translucentBlendOp = "None";
};

singleton Material(KIA_RIO_Toner_vehicle_generic_glasswindows2__env_2_spec_trans_)
{
   mapTo = "Toner_vehicle_generic_glasswindows2__env_2_spec_trans_";
   translucentBlendOp = "PreMulAlpha";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07 1";
   opacityFactor[0] = "0.99000001";
   metallicFactor[0] = "1";
   translucent = "1";
   dynamicCubemap = "1";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
};

singleton Material(KIA_RIO_tyrer_wheel__env_50_spec_)
{
   mapTo = "tyrer_wheel__env_50_spec_";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.173999995";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.812430978 0.812422991 0.812422991 1";
   metallicFactor[0] = "0.529999971";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Plastic_bumg)
{
   mapTo = "Plastic_bumg";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.699000001";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.131258994 0.131257996 0.131257996 1";
   metallicFactor[0] = "0.0170000009";
   dynamicCubemap = "1";
   doubleSided = "1";
};

singleton Material(KIA_RIO_Txi_rio)
{
   mapTo = "Txi_rio";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.740999997";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.891407013 0.68640101 0 1";
   metallicFactor[0] = "0.592000008";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_RIo_Bagaj)
{
   mapTo = "RIo_Bagaj";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.49000001";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.471845001 0.471839994 0.471839994 1";
   metallicFactor[0] = "0.949999988";
   emissiveFactor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07";
   doubleSided = "1";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Chrom_2)
{
   mapTo = "Chrom_2";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.999989986 1 1 1";
   metallicFactor[0] = "0.723999977";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Plastick2)
{
   mapTo = "Plastick2";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.755999982";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.234915003 0.234913006 0.234913006 1";
   metallicFactor[0] = "0.836000025";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Gr_666__spec_)
{
   mapTo = "Gr_666__spec_";
   translucentBlendOp = "AddAlpha";
   version = "1.5";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/666.png";
   baseColorFactor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07 1";
   translucent = "1";
};

singleton Material(KIA_RIO_Gri_suruburi__spec_)
{
   mapTo = "Gri_suruburi__spec_";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.629000008";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/Suruburi.png";
   baseColorFactor[0] = "0.471845001 0.471839994 0.471839994 1";
   metallicFactor[0] = "0.861000001";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_GR_wed_105__spec_)
{
   mapTo = "GR_wed_105__spec_";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.240999997";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/wed_105.png";
   baseColorFactor[0] = "0.960511982 0.960502028 0.960502028 1";
   metallicFactor[0] = "0.786000013";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Rio_Steklo_pered_far)
{
   mapTo = "Rio_Steklo_pered_far";
   translucentBlendOp = "PreMulAlpha";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.526140988 0.526135981 0.526135981 1";
   opacityFactor[0] = "0.465000004";
   metallicFactor[0] = "0.391000003";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   translucent = "1";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Gr_noghre__env_19_spec_)
{
   mapTo = "Gr_noghre__env_19_spec_";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "0";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0.880999982";
   baseColorMap[0] = "/vehicles/KIA RIO/TXT/noghre.png";
   baseColorFactor[0] = "0.560693026 0.560693026 0.560688019 1";
   opacityFactor[0] = "0.796000004";
   metallicFactor[0] = "0.312999994";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Grm_Hrom)
{
   mapTo = "Grm_Hrom";
   specular[0] = "0.015625 0.015625 0.015625 1";
   doubleSided = "1";
   translucentBlendOp = "None";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "0.526140988 0 0 1";
   metallicFactor[0] = "0.964999974";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   dynamicCubemap = "1";
};

singleton Material(KIA_RIO_Kia_airbag)
{
   mapTo = "Kia_airbag";
   diffuseColor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07 1";
   translucentBlendOp = "AddAlpha";
   translucent = "1";
};

singleton Material(KIA_RIO_Arbg_Dmg)
{
   mapTo = "Arbg_Dmg";
   specular[0] = "0.5 0.5 0.5 1";
   doubleSided = "0";
   translucentBlendOp = "AddAlpha";
   version = "1.5";
   roughnessFactor[0] = "0.89200002";
   baseColorMap[0] = "/vehicles/KIA RIO/PBR/null.dds";
   baseColorFactor[0] = "9.99999997e-07 9.99999997e-07 9.99999997e-07 1";
   metallicFactor[0] = "0.651000023";
   translucent = "1";
};
