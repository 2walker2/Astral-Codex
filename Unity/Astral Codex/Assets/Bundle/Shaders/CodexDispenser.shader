// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:6723,x:34175,y:32771,varname:node_6723,prsc:2|diff-493-OUT,spec-3599-OUT,gloss-5190-OUT,normal-9263-OUT,emission-5855-RGB,transm-6609-OUT,alpha-5322-OUT,voffset-5769-OUT;n:type:ShaderForge.SFN_Color,id:1071,x:32312,y:31805,ptovrint:False,ptlb:BaseColor1,ptin:_BaseColor1,varname:node_1071,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:1932,x:32035,y:32640,ptovrint:False,ptlb:DepthBlendDistance,ptin:_DepthBlendDistance,varname:node_1932,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2000;n:type:ShaderForge.SFN_DepthBlend,id:9619,x:32270,y:32640,varname:node_9619,prsc:2|DIST-1932-OUT;n:type:ShaderForge.SFN_Color,id:9191,x:32894,y:32032,ptovrint:False,ptlb:HighlightColor,ptin:_HighlightColor,varname:node_9191,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:9400,x:33108,y:32217,varname:node_9400,prsc:2|A-9191-RGB,B-346-OUT,T-8106-OUT;n:type:ShaderForge.SFN_ValueProperty,id:172,x:32289,y:32411,ptovrint:False,ptlb:DepthThresholdMin,ptin:_DepthThresholdMin,varname:node_172,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:2798,x:32289,y:32494,ptovrint:False,ptlb:DepthThresholdMax,ptin:_DepthThresholdMax,varname:node_2798,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Smoothstep,id:8106,x:32550,y:32447,varname:node_8106,prsc:2|A-172-OUT,B-2798-OUT,V-9619-OUT;n:type:ShaderForge.SFN_Time,id:7644,x:31481,y:34193,varname:node_7644,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:8457,x:31481,y:34355,ptovrint:False,ptlb:NoiseFallSpeed,ptin:_NoiseFallSpeed,varname:node_8457,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:8124,x:31689,y:34257,varname:node_8124,prsc:2|A-7644-T,B-8457-OUT;n:type:ShaderForge.SFN_Add,id:4926,x:32065,y:34107,varname:node_4926,prsc:2|A-7296-OUT,B-5573-OUT;n:type:ShaderForge.SFN_Append,id:5573,x:31865,y:34227,varname:node_5573,prsc:2|A-5029-OUT,B-8124-OUT;n:type:ShaderForge.SFN_Vector1,id:5029,x:31689,y:34176,varname:node_5029,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:1435,x:33113,y:33695,varname:node_1435,prsc:2|A-3094-OUT,B-7835-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7835,x:32885,y:33939,ptovrint:False,ptlb:VertexOffsetStrength,ptin:_VertexOffsetStrength,varname:node_7835,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:5769,x:33326,y:33695,varname:node_5769,prsc:2|A-1435-OUT,B-7646-OUT;n:type:ShaderForge.SFN_NormalVector,id:7646,x:33113,y:33841,prsc:2,pt:False;n:type:ShaderForge.SFN_FragmentPosition,id:8245,x:31474,y:33881,varname:node_8245,prsc:2;n:type:ShaderForge.SFN_Transform,id:1444,x:31662,y:33881,varname:node_1444,prsc:2,tffrom:0,tfto:1|IN-8245-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:7296,x:31854,y:33959,varname:node_7296,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-1444-XYZ;n:type:ShaderForge.SFN_Multiply,id:9278,x:32309,y:34107,varname:node_9278,prsc:2|A-334-OUT,B-4926-OUT;n:type:ShaderForge.SFN_ValueProperty,id:334,x:32103,y:33855,ptovrint:False,ptlb:NoiseScale,ptin:_NoiseScale,varname:node_334,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.6;n:type:ShaderForge.SFN_Tex2dAsset,id:8950,x:32406,y:33710,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_8950,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ed52176dbd204314a8bbf2cf3da84543,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9261,x:32624,y:33766,varname:node_9261,prsc:2,tex:ed52176dbd204314a8bbf2cf3da84543,ntxv:0,isnm:False|UVIN-9278-OUT,TEX-8950-TEX;n:type:ShaderForge.SFN_Tex2d,id:3319,x:32624,y:33557,varname:node_3319,prsc:2,tex:ed52176dbd204314a8bbf2cf3da84543,ntxv:0,isnm:False|UVIN-2611-OUT,TEX-8950-TEX;n:type:ShaderForge.SFN_Add,id:3094,x:32842,y:33701,varname:node_3094,prsc:2|A-3319-R,B-9261-R;n:type:ShaderForge.SFN_ComponentMask,id:9148,x:31854,y:33730,varname:node_9148,prsc:2,cc1:0,cc2:2,cc3:-1,cc4:-1|IN-1444-XYZ;n:type:ShaderForge.SFN_Multiply,id:2611,x:32328,y:33549,varname:node_2611,prsc:2|A-1849-OUT,B-334-OUT;n:type:ShaderForge.SFN_Add,id:1849,x:32103,y:33597,varname:node_1849,prsc:2|A-776-OUT,B-9148-OUT;n:type:ShaderForge.SFN_Time,id:6698,x:31491,y:33422,varname:node_6698,prsc:2;n:type:ShaderForge.SFN_Multiply,id:776,x:31687,y:33478,varname:node_776,prsc:2|A-6698-T,B-2794-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2794,x:31491,y:33611,ptovrint:False,ptlb:NoiseHorizontalSpeed,ptin:_NoiseHorizontalSpeed,varname:node_2794,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.4;n:type:ShaderForge.SFN_ValueProperty,id:6609,x:33693,y:33105,ptovrint:False,ptlb:Transmission,ptin:_Transmission,varname:node_6609,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Color,id:5855,x:33693,y:32943,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_5855,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:5190,x:33683,y:32820,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5190,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:3599,x:33683,y:32722,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_3599,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Tex2d,id:973,x:32698,y:32938,ptovrint:False,ptlb:Norm,ptin:_Norm,varname:node_973,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:19bfd2b8a09c9e24d928dda1ea30ab63,ntxv:3,isnm:True|UVIN-8725-OUT;n:type:ShaderForge.SFN_Append,id:3009,x:32698,y:33145,varname:node_3009,prsc:2|A-1592-OUT,B-1921-OUT,C-3150-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3150,x:32480,y:33265,ptovrint:False,ptlb:NormStrength,ptin:_NormStrength,varname:node_3150,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9263,x:32907,y:32938,varname:node_9263,prsc:2|A-973-RGB,B-3009-OUT;n:type:ShaderForge.SFN_TexCoord,id:4864,x:32298,y:32805,varname:node_4864,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:8725,x:32499,y:32921,varname:node_8725,prsc:2|A-4864-UVOUT,B-8652-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8652,x:32298,y:33013,ptovrint:False,ptlb:NormScale,ptin:_NormScale,varname:node_8652,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Time,id:4318,x:31662,y:33134,varname:node_4318,prsc:2;n:type:ShaderForge.SFN_Sin,id:1592,x:32225,y:33095,varname:node_1592,prsc:2|IN-7130-OUT;n:type:ShaderForge.SFN_Multiply,id:7130,x:31879,y:33134,varname:node_7130,prsc:2|A-4318-T,B-998-OUT;n:type:ShaderForge.SFN_ValueProperty,id:998,x:31662,y:33303,ptovrint:False,ptlb:NormSpeed,ptin:_NormSpeed,varname:node_998,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Add,id:3426,x:32066,y:33264,varname:node_3426,prsc:2|A-7130-OUT,B-1379-OUT;n:type:ShaderForge.SFN_Sin,id:1921,x:32257,y:33231,varname:node_1921,prsc:2|IN-3426-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1379,x:31879,y:33321,ptovrint:False,ptlb:NormSinOffset,ptin:_NormSinOffset,varname:node_1379,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:9896,x:33230,y:33463,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_9896,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Fresnel,id:1343,x:33066,y:33311,varname:node_1343,prsc:2|NRM-4095-OUT,EXP-2745-OUT;n:type:ShaderForge.SFN_NormalVector,id:4095,x:32864,y:33311,prsc:2,pt:True;n:type:ShaderForge.SFN_ValueProperty,id:2745,x:32864,y:33486,ptovrint:False,ptlb:FresnelExp,ptin:_FresnelExp,varname:node_2745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:5322,x:33414,y:33311,varname:node_5322,prsc:2|A-3166-OUT,B-9896-OUT;n:type:ShaderForge.SFN_OneMinus,id:3166,x:33230,y:33311,varname:node_3166,prsc:2|IN-1343-OUT;n:type:ShaderForge.SFN_Color,id:9372,x:32967,y:32395,ptovrint:False,ptlb:RimColor,ptin:_RimColor,varname:node_9372,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:493,x:33451,y:32387,varname:node_493,prsc:2|A-9400-OUT,B-9372-RGB,T-1343-OUT;n:type:ShaderForge.SFN_Color,id:8123,x:32312,y:32004,ptovrint:False,ptlb:BaseColor2,ptin:_BaseColor2,varname:node_8123,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.630724,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:8993,x:32312,y:32176,ptovrint:False,ptlb:ColorNoise,ptin:_ColorNoise,varname:node_8993,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c69ae682fdb37454582106ebcd39c492,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:346,x:32649,y:32115,varname:node_346,prsc:2|A-1071-RGB,B-8123-RGB,T-8993-R;proporder:1071-9191-1932-172-2798-8457-7835-334-8950-2794-6609-5855-5190-3599-973-3150-8652-998-1379-9896-2745-9372-8123-8993;pass:END;sub:END;*/

Shader "Custom/CodexDispenser" {
    Properties {
        _BaseColor1 ("BaseColor1", Color) = (0,0,1,1)
        _HighlightColor ("HighlightColor", Color) = (1,0,0,1)
        _DepthBlendDistance ("DepthBlendDistance", Float ) = 2000
        _DepthThresholdMin ("DepthThresholdMin", Float ) = 0
        _DepthThresholdMax ("DepthThresholdMax", Float ) = 0
        _NoiseFallSpeed ("NoiseFallSpeed", Float ) = 0.5
        _VertexOffsetStrength ("VertexOffsetStrength", Float ) = 0.2
        _NoiseScale ("NoiseScale", Float ) = 0.6
        _Noise ("Noise", 2D) = "white" {}
        _NoiseHorizontalSpeed ("NoiseHorizontalSpeed", Float ) = 0.4
        _Transmission ("Transmission", Float ) = 0
        _Emission ("Emission", Color) = (0,0,0,1)
        _Gloss ("Gloss", Float ) = 0
        _Metallic ("Metallic", Float ) = 0
        _Norm ("Norm", 2D) = "bump" {}
        _NormStrength ("NormStrength", Float ) = 1
        _NormScale ("NormScale", Float ) = 4
        _NormSpeed ("NormSpeed", Float ) = 2
        _NormSinOffset ("NormSinOffset", Float ) = 2
        _Opacity ("Opacity", Float ) = 1
        _FresnelExp ("FresnelExp", Float ) = 1
        _RimColor ("RimColor", Color) = (1,1,1,1)
        _BaseColor2 ("BaseColor2", Color) = (0.630724,0,1,1)
        _ColorNoise ("ColorNoise", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _Norm; uniform float4 _Norm_ST;
            uniform sampler2D _ColorNoise; uniform float4 _ColorNoise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor1)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendDistance)
                UNITY_DEFINE_INSTANCED_PROP( float4, _HighlightColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthThresholdMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthThresholdMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseFallSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _VertexOffsetStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseHorizontalSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _Transmission)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Emission)
                UNITY_DEFINE_INSTANCED_PROP( float, _Gloss)
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormSinOffset)
                UNITY_DEFINE_INSTANCED_PROP( float, _Opacity)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelExp)
                UNITY_DEFINE_INSTANCED_PROP( float4, _RimColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor2)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_6698 = _Time;
                float _NoiseHorizontalSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseHorizontalSpeed );
                float3 node_1444 = mul( unity_WorldToObject, float4(mul(unity_ObjectToWorld, v.vertex).rgb,0) ).xyz;
                float _NoiseScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseScale );
                float2 node_2611 = (((node_6698.g*_NoiseHorizontalSpeed_var)+node_1444.rgb.rb)*_NoiseScale_var);
                float4 node_3319 = tex2Dlod(_Noise,float4(TRANSFORM_TEX(node_2611, _Noise),0.0,0));
                float4 node_7644 = _Time;
                float _NoiseFallSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseFallSpeed );
                float2 node_9278 = (_NoiseScale_var*(node_1444.rgb.rg+float2(0.0,(node_7644.g*_NoiseFallSpeed_var))));
                float4 node_9261 = tex2Dlod(_Noise,float4(TRANSFORM_TEX(node_9278, _Noise),0.0,0));
                float _VertexOffsetStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexOffsetStrength );
                v.vertex.xyz += (((node_3319.r+node_9261.r)*_VertexOffsetStrength_var)*v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float _NormScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormScale );
                float2 node_8725 = (i.uv0*_NormScale_var);
                float3 _Norm_var = UnpackNormal(tex2D(_Norm,TRANSFORM_TEX(node_8725, _Norm)));
                float4 node_4318 = _Time;
                float _NormSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormSpeed );
                float node_7130 = (node_4318.g*_NormSpeed_var);
                float _NormSinOffset_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormSinOffset );
                float _NormStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormStrength );
                float3 normalLocal = (_Norm_var.rgb*float3(sin(node_7130),sin((node_7130+_NormSinOffset_var)),_NormStrength_var));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _Gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Gloss );
                float gloss = _Gloss_var;
                float perceptualRoughness = 1.0 - _Gloss_var;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = _Metallic_var;
                float specularMonochrome;
                float4 _HighlightColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _HighlightColor );
                float4 _BaseColor1_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor1 );
                float4 _BaseColor2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor2 );
                float4 _ColorNoise_var = tex2D(_ColorNoise,TRANSFORM_TEX(i.uv0, _ColorNoise));
                float _DepthThresholdMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthThresholdMin );
                float _DepthThresholdMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthThresholdMax );
                float _DepthBlendDistance_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendDistance );
                float4 _RimColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RimColor );
                float _FresnelExp_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelExp );
                float node_1343 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExp_var);
                float3 diffuseColor = lerp(lerp(_HighlightColor_var.rgb,lerp(_BaseColor1_var.rgb,_BaseColor2_var.rgb,_ColorNoise_var.r),smoothstep( _DepthThresholdMin_var, _DepthThresholdMax_var, saturate((sceneZ-partZ)/_DepthBlendDistance_var) )),_RimColor_var.rgb,node_1343); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 forwardLight = max(0.0, NdotL );
                float _Transmission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Transmission );
                float3 backLight = max(0.0, -NdotL ) * float3(_Transmission_var,_Transmission_var,_Transmission_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 NdotLWrap = max(0,NdotL);
                float nlPow5 = Pow5(1-NdotLWrap);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL)) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Emission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Emission );
                float3 emissive = _Emission_var.rgb;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                float _Opacity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Opacity );
                fixed4 finalRGBA = fixed4(finalColor,((1.0 - node_1343)*_Opacity_var));
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _Norm; uniform float4 _Norm_ST;
            uniform sampler2D _ColorNoise; uniform float4 _ColorNoise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor1)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthBlendDistance)
                UNITY_DEFINE_INSTANCED_PROP( float4, _HighlightColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthThresholdMin)
                UNITY_DEFINE_INSTANCED_PROP( float, _DepthThresholdMax)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseFallSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _VertexOffsetStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseHorizontalSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _Transmission)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Emission)
                UNITY_DEFINE_INSTANCED_PROP( float, _Gloss)
                UNITY_DEFINE_INSTANCED_PROP( float, _Metallic)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NormSinOffset)
                UNITY_DEFINE_INSTANCED_PROP( float, _Opacity)
                UNITY_DEFINE_INSTANCED_PROP( float, _FresnelExp)
                UNITY_DEFINE_INSTANCED_PROP( float4, _RimColor)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor2)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_6698 = _Time;
                float _NoiseHorizontalSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseHorizontalSpeed );
                float3 node_1444 = mul( unity_WorldToObject, float4(mul(unity_ObjectToWorld, v.vertex).rgb,0) ).xyz;
                float _NoiseScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseScale );
                float2 node_2611 = (((node_6698.g*_NoiseHorizontalSpeed_var)+node_1444.rgb.rb)*_NoiseScale_var);
                float4 node_3319 = tex2Dlod(_Noise,float4(TRANSFORM_TEX(node_2611, _Noise),0.0,0));
                float4 node_7644 = _Time;
                float _NoiseFallSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseFallSpeed );
                float2 node_9278 = (_NoiseScale_var*(node_1444.rgb.rg+float2(0.0,(node_7644.g*_NoiseFallSpeed_var))));
                float4 node_9261 = tex2Dlod(_Noise,float4(TRANSFORM_TEX(node_9278, _Noise),0.0,0));
                float _VertexOffsetStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexOffsetStrength );
                v.vertex.xyz += (((node_3319.r+node_9261.r)*_VertexOffsetStrength_var)*v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float _NormScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormScale );
                float2 node_8725 = (i.uv0*_NormScale_var);
                float3 _Norm_var = UnpackNormal(tex2D(_Norm,TRANSFORM_TEX(node_8725, _Norm)));
                float4 node_4318 = _Time;
                float _NormSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormSpeed );
                float node_7130 = (node_4318.g*_NormSpeed_var);
                float _NormSinOffset_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormSinOffset );
                float _NormStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NormStrength );
                float3 normalLocal = (_Norm_var.rgb*float3(sin(node_7130),sin((node_7130+_NormSinOffset_var)),_NormStrength_var));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float _Gloss_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Gloss );
                float gloss = _Gloss_var;
                float perceptualRoughness = 1.0 - _Gloss_var;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float _Metallic_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Metallic );
                float3 specularColor = _Metallic_var;
                float specularMonochrome;
                float4 _HighlightColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _HighlightColor );
                float4 _BaseColor1_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor1 );
                float4 _BaseColor2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor2 );
                float4 _ColorNoise_var = tex2D(_ColorNoise,TRANSFORM_TEX(i.uv0, _ColorNoise));
                float _DepthThresholdMin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthThresholdMin );
                float _DepthThresholdMax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthThresholdMax );
                float _DepthBlendDistance_var = UNITY_ACCESS_INSTANCED_PROP( Props, _DepthBlendDistance );
                float4 _RimColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _RimColor );
                float _FresnelExp_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FresnelExp );
                float node_1343 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExp_var);
                float3 diffuseColor = lerp(lerp(_HighlightColor_var.rgb,lerp(_BaseColor1_var.rgb,_BaseColor2_var.rgb,_ColorNoise_var.r),smoothstep( _DepthThresholdMin_var, _DepthThresholdMax_var, saturate((sceneZ-partZ)/_DepthBlendDistance_var) )),_RimColor_var.rgb,node_1343); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 forwardLight = max(0.0, NdotL );
                float _Transmission_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Transmission );
                float3 backLight = max(0.0, -NdotL ) * float3(_Transmission_var,_Transmission_var,_Transmission_var);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 NdotLWrap = max(0,NdotL);
                float nlPow5 = Pow5(1-NdotLWrap);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL)) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float _Opacity_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Opacity );
                fixed4 finalRGBA = fixed4(finalColor * ((1.0 - node_1343)*_Opacity_var),0);
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
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseFallSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _VertexOffsetStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseHorizontalSpeed)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_6698 = _Time;
                float _NoiseHorizontalSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseHorizontalSpeed );
                float3 node_1444 = mul( unity_WorldToObject, float4(mul(unity_ObjectToWorld, v.vertex).rgb,0) ).xyz;
                float _NoiseScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseScale );
                float2 node_2611 = (((node_6698.g*_NoiseHorizontalSpeed_var)+node_1444.rgb.rb)*_NoiseScale_var);
                float4 node_3319 = tex2Dlod(_Noise,float4(TRANSFORM_TEX(node_2611, _Noise),0.0,0));
                float4 node_7644 = _Time;
                float _NoiseFallSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseFallSpeed );
                float2 node_9278 = (_NoiseScale_var*(node_1444.rgb.rg+float2(0.0,(node_7644.g*_NoiseFallSpeed_var))));
                float4 node_9261 = tex2Dlod(_Noise,float4(TRANSFORM_TEX(node_9278, _Noise),0.0,0));
                float _VertexOffsetStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _VertexOffsetStrength );
                v.vertex.xyz += (((node_3319.r+node_9261.r)*_VertexOffsetStrength_var)*v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
