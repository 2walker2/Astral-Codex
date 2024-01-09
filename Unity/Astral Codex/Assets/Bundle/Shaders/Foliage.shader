// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:1,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:2,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4688,x:33481,y:33518,varname:node_4688,prsc:2|diff-8861-OUT,diffpow-2005-OUT,transm-5531-OUT,clip-8250-OUT,voffset-2199-OUT;n:type:ShaderForge.SFN_Tex2d,id:6081,x:32184,y:32286,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_6081,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6547cd56d78e37347aeb40bfc1252b34,ntxv:0,isnm:False|UVIN-6243-OUT;n:type:ShaderForge.SFN_Color,id:5685,x:32009,y:32474,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_5685,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.3254717,c3:0.3322866,c4:1;n:type:ShaderForge.SFN_Multiply,id:8861,x:32521,y:32308,varname:node_8861,prsc:2|A-6081-RGB,B-1756-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3243,x:32009,y:32651,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_3243,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Multiply,id:1756,x:32221,y:32495,varname:node_1756,prsc:2|A-5685-RGB,B-3243-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2005,x:32880,y:33668,ptovrint:False,ptlb:DiffusePower,ptin:_DiffusePower,varname:node_2005,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:3133,x:31562,y:32404,varname:node_3133,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:9418,x:30934,y:32014,ptovrint:False,ptlb:UVDistortionTexture,ptin:_UVDistortionTexture,varname:_UVDistortionTexture_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6338747e61b383c4c925842959fd96a0,ntxv:0,isnm:False|UVIN-830-OUT;n:type:ShaderForge.SFN_TexCoord,id:8373,x:29826,y:31986,varname:node_8373,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:8291,x:29767,y:31419,varname:node_8291,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7508,x:29984,y:31474,varname:node_7508,prsc:2|A-8291-T,B-3450-OUT;n:type:ShaderForge.SFN_Add,id:830,x:30303,y:31803,varname:node_830,prsc:2|A-7508-OUT,B-3854-OUT;n:type:ShaderForge.SFN_Multiply,id:3854,x:30075,y:31986,varname:node_3854,prsc:2|A-8373-UVOUT,B-7896-OUT;n:type:ShaderForge.SFN_Multiply,id:9159,x:31562,y:32245,varname:node_9159,prsc:2|A-9996-OUT,B-8595-OUT;n:type:ShaderForge.SFN_Add,id:6243,x:31781,y:32307,varname:node_6243,prsc:2|A-9159-OUT,B-3133-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:1507,x:31138,y:32057,varname:node_1507,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-9418-RGB;n:type:ShaderForge.SFN_Subtract,id:9996,x:31342,y:32136,varname:node_9996,prsc:2|A-1507-OUT,B-8845-OUT;n:type:ShaderForge.SFN_Vector1,id:8845,x:31138,y:32220,varname:node_8845,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector4Property,id:4930,x:30686,y:33124,ptovrint:False,ptlb:UVDistortionStrengthBase,ptin:_UVDistortionStrengthBase,varname:_UVDistortionStrengthBase_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.05,v2:0.05,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:695,x:30880,y:33124,varname:node_695,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4930-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:8629,x:29568,y:31581,ptovrint:False,ptlb:UVDistortionSpeed,ptin:_UVDistortionSpeed,varname:_UVDistortionSpeed_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01,v2:0.01,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:3450,x:29747,y:31581,varname:node_3450,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8629-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:5589,x:29625,y:32167,ptovrint:False,ptlb:UVDistortionScale,ptin:_UVDistortionScale,varname:_UVDistortionScale_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1,v2:0.1,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:7896,x:29815,y:32167,varname:node_7896,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-5589-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:8094,x:30489,y:32913,ptovrint:False,ptlb:UVDistortionStrengthHeight,ptin:_UVDistortionStrengthHeight,varname:_UVDistortionStrengthHeight_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3,v2:0.25,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:1587,x:30680,y:32913,varname:node_1587,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8094-XYZ;n:type:ShaderForge.SFN_Multiply,id:7837,x:30880,y:32913,varname:node_7837,prsc:2|A-4663-OUT,B-1587-OUT;n:type:ShaderForge.SFN_TexCoord,id:4403,x:30489,y:32738,varname:node_4403,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:8595,x:31111,y:32976,varname:node_8595,prsc:2|A-7837-OUT,B-695-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9466,x:30489,y:32597,ptovrint:False,ptlb:UVDistortionStrengthHeightThreshold,ptin:_UVDistortionStrengthHeightThreshold,varname:_UVDistortionStrengthHeightThreshold_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Smoothstep,id:4663,x:30680,y:32672,varname:node_4663,prsc:2|A-9466-OUT,B-3919-OUT,V-4403-V;n:type:ShaderForge.SFN_Vector1,id:3919,x:30489,y:32672,varname:node_3919,prsc:2,v1:1;n:type:ShaderForge.SFN_Time,id:2236,x:31028,y:36640,varname:node_2236,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2584,x:31201,y:36593,varname:node_2584,prsc:2|A-874-OUT,B-2236-T;n:type:ShaderForge.SFN_TexCoord,id:7110,x:31038,y:36093,varname:node_7110,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Sin,id:2547,x:31787,y:36470,varname:node_2547,prsc:2|IN-2172-OUT;n:type:ShaderForge.SFN_Multiply,id:1697,x:31233,y:36233,varname:node_1697,prsc:2|A-7110-V,B-5072-OUT;n:type:ShaderForge.SFN_Add,id:2172,x:31598,y:36470,varname:node_2172,prsc:2|A-1697-OUT,B-2584-OUT;n:type:ShaderForge.SFN_Multiply,id:1605,x:32211,y:35863,varname:node_1605,prsc:2|A-380-OUT,B-2547-OUT;n:type:ShaderForge.SFN_TexCoord,id:1797,x:30720,y:35695,varname:node_1797,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:8856,x:30720,y:35562,ptovrint:False,ptlb:VertexDistortionStrengthHeightThreshold,ptin:_VertexDistortionStrengthHeightThreshold,varname:node_8856,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Smoothstep,id:4356,x:30947,y:35606,varname:node_4356,prsc:2|A-8856-OUT,B-6800-OUT,V-1797-V;n:type:ShaderForge.SFN_Vector1,id:6800,x:30720,y:35629,varname:node_6800,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:9087,x:31159,y:35548,varname:node_9087,prsc:2|A-9427-OUT,B-4356-OUT;n:type:ShaderForge.SFN_Add,id:6563,x:31390,y:35343,varname:node_6563,prsc:2|A-8964-OUT,B-9087-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5531,x:32880,y:33785,ptovrint:False,ptlb:LightTransmission,ptin:_LightTransmission,varname:node_5531,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.75;n:type:ShaderForge.SFN_NormalVector,id:629,x:32211,y:35997,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:2199,x:32797,y:35846,varname:node_2199,prsc:2|A-8830-OUT,B-629-OUT;n:type:ShaderForge.SFN_Tex2d,id:5350,x:31607,y:34582,ptovrint:False,ptlb:VertexDistortionXTexture,ptin:_VertexDistortionXTexture,varname:node_5350,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6338747e61b383c4c925842959fd96a0,ntxv:0,isnm:False|UVIN-1631-OUT;n:type:ShaderForge.SFN_Append,id:1631,x:31413,y:34582,varname:node_1631,prsc:2|A-9502-OUT,B-8870-OUT;n:type:ShaderForge.SFN_Time,id:1823,x:30722,y:34435,varname:node_1823,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7705,x:30897,y:34515,varname:node_7705,prsc:2|A-1823-T,B-6369-OUT;n:type:ShaderForge.SFN_Multiply,id:8881,x:32064,y:34712,varname:node_8881,prsc:2|A-3812-OUT,B-5151-OUT;n:type:ShaderForge.SFN_Add,id:8830,x:32571,y:35722,varname:node_8830,prsc:2|A-8881-OUT,B-1605-OUT;n:type:ShaderForge.SFN_Subtract,id:3812,x:31871,y:34634,varname:node_3812,prsc:2|A-5350-R,B-5144-OUT;n:type:ShaderForge.SFN_Vector1,id:5144,x:31607,y:34783,varname:node_5144,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:9502,x:31103,y:34725,varname:node_9502,prsc:2|A-4728-OUT,B-9920-U;n:type:ShaderForge.SFN_Frac,id:8870,x:31103,y:34515,varname:node_8870,prsc:2|IN-7705-OUT;n:type:ShaderForge.SFN_Vector4Property,id:7060,x:30720,y:35370,ptovrint:False,ptlb:VertexDistortionStrengthHeight,ptin:_VertexDistortionStrengthHeight,varname:node_7060,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2,v2:0.5,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:9427,x:30947,y:35447,varname:node_9427,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7060-XYZ;n:type:ShaderForge.SFN_TexCoord,id:9920,x:30897,y:34791,varname:node_9920,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector4Property,id:5794,x:30862,y:35187,ptovrint:False,ptlb:VertexDistortionStrengthBase,ptin:_VertexDistortionStrengthBase,varname:node_5794,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:8964,x:31055,y:35187,varname:node_8964,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-5794-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:5151,x:31586,y:35201,varname:node_5151,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6563-OUT;n:type:ShaderForge.SFN_ComponentMask,id:380,x:31586,y:35390,varname:node_380,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6563-OUT;n:type:ShaderForge.SFN_Vector4Property,id:4409,x:29337,y:35399,ptovrint:False,ptlb:VertexDistortionSpeed,ptin:_VertexDistortionSpeed,varname:node_4409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.05,v2:1,v3:0,v4:0;n:type:ShaderForge.SFN_Vector4Property,id:7348,x:29330,y:35748,ptovrint:False,ptlb:VertexDistortionScale,ptin:_VertexDistortionScale,varname:node_7348,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1,v2:5,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:6369,x:29564,y:35332,varname:node_6369,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-4409-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:874,x:29564,y:35488,varname:node_874,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-4409-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:4728,x:29564,y:35686,varname:node_4728,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-7348-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:5072,x:29564,y:35852,varname:node_5072,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-7348-XYZ;n:type:ShaderForge.SFN_Smoothstep,id:7520,x:30375,y:33947,varname:node_7520,prsc:2|A-9378-OUT,B-143-OUT,V-306-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9378,x:30104,y:33892,ptovrint:False,ptlb:DepthBlendMin,ptin:_DepthBlendMin,varname:node_9378,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:143,x:30104,y:33974,ptovrint:False,ptlb:DepthBlendMax,ptin:_DepthBlendMax,varname:node_143,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ScreenPos,id:3825,x:31327,y:33670,varname:node_3825,prsc:2,sctp:2;n:type:ShaderForge.SFN_ScreenParameters,id:6064,x:31150,y:33546,varname:node_6064,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8464,x:31548,y:33546,varname:node_8464,prsc:2|A-9627-OUT,B-3825-UVOUT;n:type:ShaderForge.SFN_Append,id:9627,x:31327,y:33546,varname:node_9627,prsc:2|A-6064-PXW,B-6064-PXH;n:type:ShaderForge.SFN_Fmod,id:2185,x:31750,y:33546,varname:node_2185,prsc:2|A-8464-OUT,B-3965-OUT;n:type:ShaderForge.SFN_Multiply,id:8250,x:32880,y:33500,varname:node_8250,prsc:2|A-6081-A,B-9258-OUT,C-6956-OUT;n:type:ShaderForge.SFN_ComponentMask,id:5193,x:32160,y:33419,varname:node_5193,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-672-OUT;n:type:ShaderForge.SFN_ComponentMask,id:8379,x:32160,y:33607,varname:node_8379,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-672-OUT;n:type:ShaderForge.SFN_Clamp01,id:9258,x:32578,y:33517,varname:node_9258,prsc:2|IN-963-OUT;n:type:ShaderForge.SFN_Step,id:672,x:31942,y:33546,varname:node_672,prsc:2|A-2185-OUT,B-4673-OUT;n:type:ShaderForge.SFN_Vector1,id:4673,x:31750,y:33681,varname:node_4673,prsc:2,v1:0.6;n:type:ShaderForge.SFN_Multiply,id:963,x:32385,y:33517,varname:node_963,prsc:2|A-5193-OUT,B-8379-OUT;n:type:ShaderForge.SFN_Multiply,id:320,x:30736,y:33947,varname:node_320,prsc:2|A-4880-OUT,B-5457-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5457,x:30547,y:34122,ptovrint:False,ptlb:MaxDitherValue,ptin:_MaxDitherValue,varname:node_5457,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:3965,x:31297,y:33950,varname:node_3965,prsc:2|A-1323-OUT,B-1323-OUT;n:type:ShaderForge.SFN_OneMinus,id:4880,x:30547,y:33947,varname:node_4880,prsc:2|IN-7520-OUT;n:type:ShaderForge.SFN_Max,id:1323,x:31116,y:33950,varname:node_1323,prsc:2|A-5938-OUT,B-8463-OUT;n:type:ShaderForge.SFN_Vector1,id:8463,x:30931,y:34117,varname:node_8463,prsc:2,v1:1;n:type:ShaderForge.SFN_Floor,id:5938,x:30931,y:33950,varname:node_5938,prsc:2|IN-320-OUT;n:type:ShaderForge.SFN_Distance,id:306,x:30104,y:34052,varname:node_306,prsc:2|A-9353-XYZ,B-6602-XYZ;n:type:ShaderForge.SFN_ViewPosition,id:6602,x:29859,y:34103,varname:node_6602,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:2500,x:32057,y:34229,ptovrint:False,ptlb:DepthBlendVanishTreshold,ptin:_DepthBlendVanishTreshold,varname:node_2500,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Step,id:5994,x:32244,y:34157,varname:node_5994,prsc:2|A-5672-OUT,B-2500-OUT;n:type:ShaderForge.SFN_OneMinus,id:6956,x:32417,y:34157,varname:node_6956,prsc:2|IN-5994-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:3496,x:31814,y:33977,varname:node_3496,prsc:2;n:type:ShaderForge.SFN_Distance,id:5672,x:32057,y:34065,varname:node_5672,prsc:2|A-3496-XYZ,B-2041-XYZ;n:type:ShaderForge.SFN_ViewPosition,id:2041,x:31814,y:34118,varname:node_2041,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:9353,x:29859,y:33963,varname:node_9353,prsc:2;proporder:6081-5685-3243-2005-5531-9418-8629-5589-4930-8094-9466-4409-7348-5794-7060-8856-5350-9378-143-5457-2500;pass:END;sub:END;*/

Shader "Custom/Foliage" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _Color ("Color", Color) = (1,0.3254717,0.3322866,1)
        _Brightness ("Brightness", Float ) = 4
        _DiffusePower ("DiffusePower", Float ) = 0.5
        _LightTransmission ("LightTransmission", Float ) = 0.75
        _UVDistortionTexture ("UVDistortionTexture", 2D) = "white" {}
        _UVDistortionSpeed ("UVDistortionSpeed", Vector) = (0.01,0.01,0,0)
        _UVDistortionScale ("UVDistortionScale", Vector) = (0.1,0.1,0,0)
        _UVDistortionStrengthBase ("UVDistortionStrengthBase", Vector) = (0.05,0.05,0,0)
        _UVDistortionStrengthHeight ("UVDistortionStrengthHeight", Vector) = (0.3,0.25,0,0)
        _UVDistortionStrengthHeightThreshold ("UVDistortionStrengthHeightThreshold", Float ) = 0
        _VertexDistortionSpeed ("VertexDistortionSpeed", Vector) = (0.05,1,0,0)
        _VertexDistortionScale ("VertexDistortionScale", Vector) = (1,5,0,0)
        _VertexDistortionStrengthBase ("VertexDistortionStrengthBase", Vector) = (0,0,0,0)
        _VertexDistortionStrengthHeight ("VertexDistortionStrengthHeight", Vector) = (2,0.5,0,0)
        _VertexDistortionStrengthHeightThreshold ("VertexDistortionStrengthHeightThreshold", Float ) = 0.2
        _VertexDistortionXTexture ("VertexDistortionXTexture", 2D) = "white" {}
        _DepthBlendMin ("DepthBlendMin", Float ) = 0
        _DepthBlendMax ("DepthBlendMax", Float ) = 0
        _MaxDitherValue ("MaxDitherValue", Float ) = 0
        _DepthBlendVanishTreshold ("DepthBlendVanishTreshold", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
            "PreviewType"="Plane"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _UVDistortionTexture; uniform float4 _UVDistortionTexture_ST;
            uniform sampler2D _VertexDistortionXTexture; uniform float4 _VertexDistortionXTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _Brightness)
                UNITY_DEFINE_INSTANCED_PROP( float, _DiffusePower)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionStrengthBase)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionScale)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionStrengthHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _UVDistortionStrengthHeightThreshold)
                UNITY_DEFINE_INSTANCED_PROP( float, _VertexDistortionStrengthHeightThreshold)
                UNITY_DEFINE_INSTANCED_PROP( float, _LightTransmission)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionStrengthHeight)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionStrengthBase)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _MaxDitherValue)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendVanishTreshold)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 _VertexDistortionScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionScale );
                float4 node_1823 = _Time;
                float4 _VertexDistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionSpeed );
                float2 node_1631 = float2((_VertexDistortionScale_var.rgb.r*o.uv0.r),frac((node_1823.g*_VertexDistortionSpeed_var.rgb.r)));
                float4 _VertexDistortionXTexture_var = tex2Dlod(_VertexDistortionXTexture,float4(TRANSFORM_TEX(node_1631, _VertexDistortionXTexture),0.0,0));
                float4 _VertexDistortionStrengthBase_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthBase );
                float4 _VertexDistortionStrengthHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthHeight );
                float _VertexDistortionStrengthHeightThreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthHeightThreshold );
                float2 node_6563 = (_VertexDistortionStrengthBase_var.rgb.rg+(_VertexDistortionStrengthHeight_var.rgb.rg*smoothstep( _VertexDistortionStrengthHeightThreshold_var, 1.0, o.uv0.g )));
                float4 node_2236 = _Time;
                v.vertex.xyz += ((((_VertexDistortionXTexture_var.r-0.5)*node_6563.r)+(node_6563.g*sin(((o.uv0.g*_VertexDistortionScale_var.rgb.g)+(_VertexDistortionSpeed_var.rgb.g*node_2236.g)))))*v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 node_8291 = _Time;
                float4 _UVDistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionSpeed );
                float4 _UVDistortionScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionScale );
                float2 node_830 = ((node_8291.g*_UVDistortionSpeed_var.rgb.rg)+(i.uv0*_UVDistortionScale_var.rgb.rg));
                float4 _UVDistortionTexture_var = tex2D(_UVDistortionTexture,TRANSFORM_TEX(node_830, _UVDistortionTexture));
                float _UVDistortionStrengthHeightThreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthHeightThreshold );
                float4 _UVDistortionStrengthHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthHeight );
                float4 _UVDistortionStrengthBase_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthBase );
                float2 node_6243 = (((_UVDistortionTexture_var.rgb.rg-0.5)*((smoothstep( _UVDistortionStrengthHeightThreshold_var, 1.0, i.uv0.g )*_UVDistortionStrengthHeight_var.rgb.rg)+_UVDistortionStrengthBase_var.rgb.rg))+i.uv0);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_6243, _MainTex));
                float _DepthBlendMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendMin );
                float _DepthBlendMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendMax );
                float _MaxDitherValue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MaxDitherValue );
                float node_1323 = max(floor(((1.0 - smoothstep( _DepthBlendMin_var, _DepthBlendMax_var, distance(objPos.rgb,_WorldSpaceCameraPos) ))*_MaxDitherValue_var)),1.0);
                float2 node_672 = step(fmod((float2(_ScreenParams.r,_ScreenParams.g)*sceneUVs.rg),float2(node_1323,node_1323)),0.6);
                float _DepthBlendVanishTreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendVanishTreshold );
                clip((_MainTex_var.a*saturate((node_672.r*node_672.g))*(1.0 - step(distance(i.posWorld.rgb,_WorldSpaceCameraPos),_DepthBlendVanishTreshold_var))) - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = dot( normalDirection, lightDirection );
                float _DiffusePower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DiffusePower );
                float3 forwardLight = pow(max(0.0, NdotL ), _DiffusePower_var);
                float _LightTransmission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _LightTransmission );
                float3 backLight = pow(max(0.0, -NdotL ), _DiffusePower_var) * float3(_LightTransmission_var,_LightTransmission_var,_LightTransmission_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float _Brightness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Brightness );
                float3 diffuseColor = (_MainTex_var.rgb*(_Color_var.rgb*_Brightness_var));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _UVDistortionTexture; uniform float4 _UVDistortionTexture_ST;
            uniform sampler2D _VertexDistortionXTexture; uniform float4 _VertexDistortionXTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _Brightness)
                UNITY_DEFINE_INSTANCED_PROP( float, _DiffusePower)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionStrengthBase)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionScale)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionStrengthHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _UVDistortionStrengthHeightThreshold)
                UNITY_DEFINE_INSTANCED_PROP( float, _VertexDistortionStrengthHeightThreshold)
                UNITY_DEFINE_INSTANCED_PROP( float, _LightTransmission)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionStrengthHeight)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionStrengthBase)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _MaxDitherValue)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendVanishTreshold)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 _VertexDistortionScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionScale );
                float4 node_1823 = _Time;
                float4 _VertexDistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionSpeed );
                float2 node_1631 = float2((_VertexDistortionScale_var.rgb.r*o.uv0.r),frac((node_1823.g*_VertexDistortionSpeed_var.rgb.r)));
                float4 _VertexDistortionXTexture_var = tex2Dlod(_VertexDistortionXTexture,float4(TRANSFORM_TEX(node_1631, _VertexDistortionXTexture),0.0,0));
                float4 _VertexDistortionStrengthBase_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthBase );
                float4 _VertexDistortionStrengthHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthHeight );
                float _VertexDistortionStrengthHeightThreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthHeightThreshold );
                float2 node_6563 = (_VertexDistortionStrengthBase_var.rgb.rg+(_VertexDistortionStrengthHeight_var.rgb.rg*smoothstep( _VertexDistortionStrengthHeightThreshold_var, 1.0, o.uv0.g )));
                float4 node_2236 = _Time;
                v.vertex.xyz += ((((_VertexDistortionXTexture_var.r-0.5)*node_6563.r)+(node_6563.g*sin(((o.uv0.g*_VertexDistortionScale_var.rgb.g)+(_VertexDistortionSpeed_var.rgb.g*node_2236.g)))))*v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 node_8291 = _Time;
                float4 _UVDistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionSpeed );
                float4 _UVDistortionScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionScale );
                float2 node_830 = ((node_8291.g*_UVDistortionSpeed_var.rgb.rg)+(i.uv0*_UVDistortionScale_var.rgb.rg));
                float4 _UVDistortionTexture_var = tex2D(_UVDistortionTexture,TRANSFORM_TEX(node_830, _UVDistortionTexture));
                float _UVDistortionStrengthHeightThreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthHeightThreshold );
                float4 _UVDistortionStrengthHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthHeight );
                float4 _UVDistortionStrengthBase_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthBase );
                float2 node_6243 = (((_UVDistortionTexture_var.rgb.rg-0.5)*((smoothstep( _UVDistortionStrengthHeightThreshold_var, 1.0, i.uv0.g )*_UVDistortionStrengthHeight_var.rgb.rg)+_UVDistortionStrengthBase_var.rgb.rg))+i.uv0);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_6243, _MainTex));
                float _DepthBlendMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendMin );
                float _DepthBlendMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendMax );
                float _MaxDitherValue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MaxDitherValue );
                float node_1323 = max(floor(((1.0 - smoothstep( _DepthBlendMin_var, _DepthBlendMax_var, distance(objPos.rgb,_WorldSpaceCameraPos) ))*_MaxDitherValue_var)),1.0);
                float2 node_672 = step(fmod((float2(_ScreenParams.r,_ScreenParams.g)*sceneUVs.rg),float2(node_1323,node_1323)),0.6);
                float _DepthBlendVanishTreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendVanishTreshold );
                clip((_MainTex_var.a*saturate((node_672.r*node_672.g))*(1.0 - step(distance(i.posWorld.rgb,_WorldSpaceCameraPos),_DepthBlendVanishTreshold_var))) - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = dot( normalDirection, lightDirection );
                float _DiffusePower_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DiffusePower );
                float3 forwardLight = pow(max(0.0, NdotL ), _DiffusePower_var);
                float _LightTransmission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _LightTransmission );
                float3 backLight = pow(max(0.0, -NdotL ), _DiffusePower_var) * float3(_LightTransmission_var,_LightTransmission_var,_LightTransmission_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float _Brightness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Brightness );
                float3 diffuseColor = (_MainTex_var.rgb*(_Color_var.rgb*_Brightness_var));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _UVDistortionTexture; uniform float4 _UVDistortionTexture_ST;
            uniform sampler2D _VertexDistortionXTexture; uniform float4 _VertexDistortionXTexture_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionStrengthBase)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionScale)
                UNITY_DEFINE_INSTANCED_PROP( float4, _UVDistortionStrengthHeight)
                UNITY_DEFINE_INSTANCED_PROP( float, _UVDistortionStrengthHeightThreshold)
                UNITY_DEFINE_INSTANCED_PROP( float, _VertexDistortionStrengthHeightThreshold)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionStrengthHeight)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionStrengthBase)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float4, _VertexDistortionScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _MaxDitherValue)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendVanishTreshold)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float4 projPos : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 _VertexDistortionScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionScale );
                float4 node_1823 = _Time;
                float4 _VertexDistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionSpeed );
                float2 node_1631 = float2((_VertexDistortionScale_var.rgb.r*o.uv0.r),frac((node_1823.g*_VertexDistortionSpeed_var.rgb.r)));
                float4 _VertexDistortionXTexture_var = tex2Dlod(_VertexDistortionXTexture,float4(TRANSFORM_TEX(node_1631, _VertexDistortionXTexture),0.0,0));
                float4 _VertexDistortionStrengthBase_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthBase );
                float4 _VertexDistortionStrengthHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthHeight );
                float _VertexDistortionStrengthHeightThreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexDistortionStrengthHeightThreshold );
                float2 node_6563 = (_VertexDistortionStrengthBase_var.rgb.rg+(_VertexDistortionStrengthHeight_var.rgb.rg*smoothstep( _VertexDistortionStrengthHeightThreshold_var, 1.0, o.uv0.g )));
                float4 node_2236 = _Time;
                v.vertex.xyz += ((((_VertexDistortionXTexture_var.r-0.5)*node_6563.r)+(node_6563.g*sin(((o.uv0.g*_VertexDistortionScale_var.rgb.g)+(_VertexDistortionSpeed_var.rgb.g*node_2236.g)))))*v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 node_8291 = _Time;
                float4 _UVDistortionSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionSpeed );
                float4 _UVDistortionScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionScale );
                float2 node_830 = ((node_8291.g*_UVDistortionSpeed_var.rgb.rg)+(i.uv0*_UVDistortionScale_var.rgb.rg));
                float4 _UVDistortionTexture_var = tex2D(_UVDistortionTexture,TRANSFORM_TEX(node_830, _UVDistortionTexture));
                float _UVDistortionStrengthHeightThreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthHeightThreshold );
                float4 _UVDistortionStrengthHeight_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthHeight );
                float4 _UVDistortionStrengthBase_var = UNITY_ACCESS_INSTANCED_PROP( Props, _UVDistortionStrengthBase );
                float2 node_6243 = (((_UVDistortionTexture_var.rgb.rg-0.5)*((smoothstep( _UVDistortionStrengthHeightThreshold_var, 1.0, i.uv0.g )*_UVDistortionStrengthHeight_var.rgb.rg)+_UVDistortionStrengthBase_var.rgb.rg))+i.uv0);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_6243, _MainTex));
                float _DepthBlendMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendMin );
                float _DepthBlendMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendMax );
                float _MaxDitherValue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _MaxDitherValue );
                float node_1323 = max(floor(((1.0 - smoothstep( _DepthBlendMin_var, _DepthBlendMax_var, distance(objPos.rgb,_WorldSpaceCameraPos) ))*_MaxDitherValue_var)),1.0);
                float2 node_672 = step(fmod((float2(_ScreenParams.r,_ScreenParams.g)*sceneUVs.rg),float2(node_1323,node_1323)),0.6);
                float _DepthBlendVanishTreshold_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendVanishTreshold );
                clip((_MainTex_var.a*saturate((node_672.r*node_672.g))*(1.0 - step(distance(i.posWorld.rgb,_WorldSpaceCameraPos),_DepthBlendVanishTreshold_var))) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
