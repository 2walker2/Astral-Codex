// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:1,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:2,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4688,x:33481,y:33518,varname:node_4688,prsc:2|diff-8861-OUT,diffpow-2005-OUT,transm-5531-OUT,clip-6081-A,voffset-2199-OUT;n:type:ShaderForge.SFN_Tex2d,id:6081,x:32281,y:32639,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_6081,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6547cd56d78e37347aeb40bfc1252b34,ntxv:0,isnm:False|UVIN-6243-OUT;n:type:ShaderForge.SFN_Color,id:5685,x:32106,y:32827,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_5685,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.3254717,c3:0.3322866,c4:1;n:type:ShaderForge.SFN_Multiply,id:8861,x:32618,y:32661,varname:node_8861,prsc:2|A-6081-RGB,B-1756-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3243,x:32106,y:33004,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_3243,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Multiply,id:1756,x:32318,y:32848,varname:node_1756,prsc:2|A-5685-RGB,B-3243-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2005,x:32850,y:33518,ptovrint:False,ptlb:DiffusePower,ptin:_DiffusePower,varname:node_2005,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:3133,x:31659,y:32757,varname:node_3133,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:9418,x:31031,y:32367,ptovrint:False,ptlb:UVDistortionTexture,ptin:_UVDistortionTexture,varname:_UVDistortionTexture_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6338747e61b383c4c925842959fd96a0,ntxv:0,isnm:False|UVIN-830-OUT;n:type:ShaderForge.SFN_TexCoord,id:8373,x:29923,y:32339,varname:node_8373,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:8291,x:29864,y:31772,varname:node_8291,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7508,x:30081,y:31827,varname:node_7508,prsc:2|A-8291-T,B-3450-OUT;n:type:ShaderForge.SFN_Add,id:830,x:30400,y:32156,varname:node_830,prsc:2|A-7508-OUT,B-3854-OUT;n:type:ShaderForge.SFN_Multiply,id:3854,x:30172,y:32339,varname:node_3854,prsc:2|A-8373-UVOUT,B-7896-OUT;n:type:ShaderForge.SFN_Multiply,id:9159,x:31659,y:32598,varname:node_9159,prsc:2|A-9996-OUT,B-8595-OUT;n:type:ShaderForge.SFN_Add,id:6243,x:31878,y:32660,varname:node_6243,prsc:2|A-9159-OUT,B-3133-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:1507,x:31235,y:32410,varname:node_1507,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-9418-RGB;n:type:ShaderForge.SFN_Subtract,id:9996,x:31439,y:32489,varname:node_9996,prsc:2|A-1507-OUT,B-8845-OUT;n:type:ShaderForge.SFN_Vector1,id:8845,x:31235,y:32573,varname:node_8845,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector4Property,id:4930,x:30783,y:33477,ptovrint:False,ptlb:UVDistortionStrengthBase,ptin:_UVDistortionStrengthBase,varname:_UVDistortionStrengthBase_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.05,v2:0.05,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:695,x:30977,y:33477,varname:node_695,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4930-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:8629,x:29665,y:31934,ptovrint:False,ptlb:UVDistortionSpeed,ptin:_UVDistortionSpeed,varname:_UVDistortionSpeed_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01,v2:0.01,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:3450,x:29844,y:31934,varname:node_3450,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8629-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:5589,x:29722,y:32520,ptovrint:False,ptlb:UVDistortionScale,ptin:_UVDistortionScale,varname:_UVDistortionScale_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1,v2:0.1,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:7896,x:29912,y:32520,varname:node_7896,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-5589-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:8094,x:30586,y:33266,ptovrint:False,ptlb:UVDistortionStrengthHeight,ptin:_UVDistortionStrengthHeight,varname:_UVDistortionStrengthHeight_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3,v2:0.25,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:1587,x:30777,y:33266,varname:node_1587,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8094-XYZ;n:type:ShaderForge.SFN_Multiply,id:7837,x:30977,y:33266,varname:node_7837,prsc:2|A-4663-OUT,B-1587-OUT;n:type:ShaderForge.SFN_TexCoord,id:4403,x:30586,y:33091,varname:node_4403,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:8595,x:31208,y:33329,varname:node_8595,prsc:2|A-7837-OUT,B-695-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9466,x:30586,y:32950,ptovrint:False,ptlb:UVDistortionStrengthHeightThreshold,ptin:_UVDistortionStrengthHeightThreshold,varname:_UVDistortionStrengthHeightThreshold_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Smoothstep,id:4663,x:30777,y:33025,varname:node_4663,prsc:2|A-9466-OUT,B-3919-OUT,V-4403-V;n:type:ShaderForge.SFN_Vector1,id:3919,x:30586,y:33025,varname:node_3919,prsc:2,v1:1;n:type:ShaderForge.SFN_Time,id:2236,x:31118,y:36053,varname:node_2236,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2584,x:31291,y:36006,varname:node_2584,prsc:2|A-874-OUT,B-2236-T;n:type:ShaderForge.SFN_TexCoord,id:7110,x:31128,y:35506,varname:node_7110,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Sin,id:2547,x:31877,y:35883,varname:node_2547,prsc:2|IN-2172-OUT;n:type:ShaderForge.SFN_Multiply,id:1697,x:31323,y:35646,varname:node_1697,prsc:2|A-7110-V,B-5072-OUT;n:type:ShaderForge.SFN_Add,id:2172,x:31688,y:35883,varname:node_2172,prsc:2|A-1697-OUT,B-2584-OUT;n:type:ShaderForge.SFN_Multiply,id:1605,x:32301,y:35276,varname:node_1605,prsc:2|A-380-OUT,B-2547-OUT;n:type:ShaderForge.SFN_TexCoord,id:1797,x:30810,y:35108,varname:node_1797,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:8856,x:30810,y:34975,ptovrint:False,ptlb:VertexDistortionStrengthHeightThreshold,ptin:_VertexDistortionStrengthHeightThreshold,varname:node_8856,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Smoothstep,id:4356,x:31037,y:35019,varname:node_4356,prsc:2|A-8856-OUT,B-6800-OUT,V-1797-V;n:type:ShaderForge.SFN_Vector1,id:6800,x:30810,y:35042,varname:node_6800,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:9087,x:31249,y:34961,varname:node_9087,prsc:2|A-9427-OUT,B-4356-OUT;n:type:ShaderForge.SFN_Add,id:6563,x:31480,y:34756,varname:node_6563,prsc:2|A-8964-OUT,B-9087-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5531,x:32850,y:33686,ptovrint:False,ptlb:LightTransmission,ptin:_LightTransmission,varname:node_5531,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.75;n:type:ShaderForge.SFN_NormalVector,id:629,x:32301,y:35410,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:2199,x:32887,y:35259,varname:node_2199,prsc:2|A-8830-OUT,B-629-OUT;n:type:ShaderForge.SFN_Tex2d,id:5350,x:31697,y:33995,ptovrint:False,ptlb:VertexDistortionXTexture,ptin:_VertexDistortionXTexture,varname:node_5350,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6338747e61b383c4c925842959fd96a0,ntxv:0,isnm:False|UVIN-1631-OUT;n:type:ShaderForge.SFN_Append,id:1631,x:31503,y:33995,varname:node_1631,prsc:2|A-9502-OUT,B-8870-OUT;n:type:ShaderForge.SFN_Time,id:1823,x:30812,y:33848,varname:node_1823,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7705,x:30987,y:33928,varname:node_7705,prsc:2|A-1823-T,B-6369-OUT;n:type:ShaderForge.SFN_Multiply,id:8881,x:32154,y:34125,varname:node_8881,prsc:2|A-3812-OUT,B-5151-OUT;n:type:ShaderForge.SFN_Add,id:8830,x:32661,y:35135,varname:node_8830,prsc:2|A-8881-OUT,B-1605-OUT;n:type:ShaderForge.SFN_Subtract,id:3812,x:31961,y:34047,varname:node_3812,prsc:2|A-5350-R,B-5144-OUT;n:type:ShaderForge.SFN_Vector1,id:5144,x:31697,y:34185,varname:node_5144,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:9502,x:31193,y:34138,varname:node_9502,prsc:2|A-4728-OUT,B-9920-U;n:type:ShaderForge.SFN_Frac,id:8870,x:31193,y:33928,varname:node_8870,prsc:2|IN-7705-OUT;n:type:ShaderForge.SFN_Vector4Property,id:7060,x:30810,y:34783,ptovrint:False,ptlb:VertexDistortionStrengthHeight,ptin:_VertexDistortionStrengthHeight,varname:node_7060,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2,v2:0.5,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:9427,x:31037,y:34860,varname:node_9427,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7060-XYZ;n:type:ShaderForge.SFN_TexCoord,id:9920,x:30987,y:34204,varname:node_9920,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector4Property,id:5794,x:30952,y:34600,ptovrint:False,ptlb:VertexDistortionStrengthBase,ptin:_VertexDistortionStrengthBase,varname:node_5794,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:8964,x:31145,y:34600,varname:node_8964,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-5794-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:5151,x:31676,y:34614,varname:node_5151,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6563-OUT;n:type:ShaderForge.SFN_ComponentMask,id:380,x:31676,y:34803,varname:node_380,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6563-OUT;n:type:ShaderForge.SFN_Vector4Property,id:4409,x:29427,y:34812,ptovrint:False,ptlb:VertexDistortionSpeed,ptin:_VertexDistortionSpeed,varname:node_4409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.05,v2:1,v3:0,v4:0;n:type:ShaderForge.SFN_Vector4Property,id:7348,x:29420,y:35161,ptovrint:False,ptlb:VertexDistortionScale,ptin:_VertexDistortionScale,varname:node_7348,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1,v2:5,v3:0,v4:0;n:type:ShaderForge.SFN_ComponentMask,id:6369,x:29654,y:34745,varname:node_6369,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-4409-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:874,x:29654,y:34901,varname:node_874,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-4409-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:4728,x:29654,y:35099,varname:node_4728,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-7348-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:5072,x:29654,y:35265,varname:node_5072,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-7348-XYZ;proporder:6081-5685-3243-2005-5531-9418-8629-5589-4930-8094-9466-4409-7348-5794-7060-8856-5350;pass:END;sub:END;*/

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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
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
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
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
                clip(_MainTex_var.a - 0.5);
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
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
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
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
                clip(_MainTex_var.a - 0.5);
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
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
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
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
                clip(_MainTex_var.a - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
