// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:1304,x:33363,y:32684,varname:node_1304,prsc:2|emission-69-OUT,alpha-9362-OUT;n:type:ShaderForge.SFN_Color,id:201,x:32235,y:32582,ptovrint:False,ptlb:BaseColor,ptin:_BaseColor,varname:node_201,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:4524,x:30673,y:33338,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_4524,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:68954c9e980bfab49bf012d176acc5e6,ntxv:0,isnm:False|UVIN-8397-OUT;n:type:ShaderForge.SFN_TexCoord,id:7823,x:30234,y:33314,varname:node_7823,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:3067,x:30234,y:33491,ptovrint:False,ptlb:NoiseScale,ptin:_NoiseScale,varname:node_3067,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.75;n:type:ShaderForge.SFN_Multiply,id:8397,x:30468,y:33355,varname:node_8397,prsc:2|A-7823-UVOUT,B-3067-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4695,x:31988,y:33238,ptovrint:False,ptlb:BorderThickness,ptin:_BorderThickness,varname:node_4695,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.025;n:type:ShaderForge.SFN_Color,id:5996,x:31350,y:32059,ptovrint:False,ptlb:BorderColor1,ptin:_BorderColor1,varname:node_5996,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.6694646,c4:1;n:type:ShaderForge.SFN_Lerp,id:69,x:32684,y:32564,varname:node_69,prsc:2|A-5919-OUT,B-201-RGB,T-2921-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3070,x:29804,y:32836,ptovrint:False,ptlb:StartTime,ptin:_StartTime,varname:node_3070,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-10000;n:type:ShaderForge.SFN_Time,id:8641,x:29896,y:32563,varname:node_8641,prsc:2;n:type:ShaderForge.SFN_Multiply,id:397,x:30840,y:32636,varname:node_397,prsc:2|A-9836-OUT,B-7575-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7575,x:30648,y:32805,ptovrint:False,ptlb:FadeSpeed,ptin:_FadeSpeed,varname:node_7575,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Subtract,id:5678,x:30089,y:32623,varname:node_5678,prsc:2|A-8641-T,B-3070-OUT;n:type:ShaderForge.SFN_OneMinus,id:5342,x:31274,y:32692,varname:node_5342,prsc:2|IN-397-OUT;n:type:ShaderForge.SFN_Time,id:1736,x:29998,y:32114,varname:node_1736,prsc:2;n:type:ShaderForge.SFN_Subtract,id:2962,x:30173,y:32137,varname:node_2962,prsc:2|A-1736-T,B-2744-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2744,x:29998,y:32290,ptovrint:False,ptlb:DEBUG_TimeOffset,ptin:_DEBUG_TimeOffset,varname:node_2744,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.5;n:type:ShaderForge.SFN_OneMinus,id:2539,x:31177,y:33460,varname:node_2539,prsc:2|IN-9264-OUT;n:type:ShaderForge.SFN_Add,id:5113,x:32224,y:33172,varname:node_5113,prsc:2|A-2459-OUT,B-4695-OUT;n:type:ShaderForge.SFN_Multiply,id:9264,x:30944,y:33460,varname:node_9264,prsc:2|A-4524-R,B-3834-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3834,x:30731,y:33584,ptovrint:False,ptlb:NoiseStrength,ptin:_NoiseStrength,varname:node_3834,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_Tex2d,id:2545,x:30849,y:31634,ptovrint:False,ptlb:BorderColorNoise,ptin:_BorderColorNoise,varname:node_2545,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:048b8fdcecc26f34eb7f5d34b574be45,ntxv:0,isnm:False|UVIN-2831-OUT;n:type:ShaderForge.SFN_Color,id:3073,x:31350,y:31899,ptovrint:False,ptlb:BorderColor2,ptin:_BorderColor2,varname:node_3073,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7349014,c2:0.2216981,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:5919,x:31595,y:31977,varname:node_5919,prsc:2|A-3073-RGB,B-5996-RGB,T-3675-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7676,x:30402,y:31767,ptovrint:False,ptlb:BorderColorNoiseScale,ptin:_BorderColorNoiseScale,varname:node_7676,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:278,x:30402,y:31590,varname:node_278,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2831,x:30634,y:31621,varname:node_2831,prsc:2|A-278-UVOUT,B-7676-OUT;n:type:ShaderForge.SFN_Multiply,id:5322,x:31085,y:31698,varname:node_5322,prsc:2|A-2545-R,B-4740-OUT;n:type:ShaderForge.SFN_Clamp01,id:3675,x:31314,y:31698,varname:node_3675,prsc:2|IN-5322-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4740,x:30849,y:31849,ptovrint:False,ptlb:BorderColorNoiseStrength,ptin:_BorderColorNoiseStrength,varname:node_4740,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Smoothstep,id:2921,x:32447,y:32885,varname:node_2921,prsc:2|A-2539-OUT,B-1405-OUT,V-2459-OUT;n:type:ShaderForge.SFN_ValueProperty,id:504,x:31927,y:32662,ptovrint:False,ptlb:BorderFadeThickness,ptin:_BorderFadeThickness,varname:node_504,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_Add,id:1405,x:32146,y:32744,varname:node_1405,prsc:2|A-504-OUT,B-2539-OUT;n:type:ShaderForge.SFN_Smoothstep,id:9362,x:32447,y:33069,varname:node_9362,prsc:2|A-2539-OUT,B-1405-OUT,V-5113-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3466,x:30278,y:32763,ptovrint:False,ptlb:FadeStartDelay,ptin:_FadeStartDelay,varname:node_3466,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Subtract,id:9836,x:30454,y:32665,varname:node_9836,prsc:2|A-5678-OUT,B-3466-OUT;n:type:ShaderForge.SFN_Relay,id:2459,x:31486,y:32726,varname:node_2459,prsc:2|IN-5342-OUT;proporder:201-4524-3067-4695-5996-3070-7575-2744-3834-2545-3073-7676-4740-504-3466;pass:END;sub:END;*/

Shader "Unlit/TesseractActivation" {
    Properties {
        _BaseColor ("BaseColor", Color) = (1,1,1,1)
        _Noise ("Noise", 2D) = "white" {}
        _NoiseScale ("NoiseScale", Float ) = 0.75
        _BorderThickness ("BorderThickness", Float ) = 0.025
        _BorderColor1 ("BorderColor1", Color) = (0,1,0.6694646,1)
        _StartTime ("StartTime", Float ) = -10000
        _FadeSpeed ("FadeSpeed", Float ) = 1
        _DEBUG_TimeOffset ("DEBUG_TimeOffset", Float ) = 1.5
        _NoiseStrength ("NoiseStrength", Float ) = 5
        _BorderColorNoise ("BorderColorNoise", 2D) = "white" {}
        _BorderColor2 ("BorderColor2", Color) = (0.7349014,0.2216981,1,1)
        _BorderColorNoiseScale ("BorderColorNoiseScale", Float ) = 0.5
        _BorderColorNoiseStrength ("BorderColorNoiseStrength", Float ) = 3
        _BorderFadeThickness ("BorderFadeThickness", Float ) = 0.3
        _FadeStartDelay ("FadeStartDelay", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 100
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
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform sampler2D _BorderColorNoise; uniform float4 _BorderColorNoise_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _BaseColor)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _BorderThickness)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BorderColor1)
                UNITY_DEFINE_INSTANCED_PROP( float, _StartTime)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeSpeed)
                UNITY_DEFINE_INSTANCED_PROP( float, _NoiseStrength)
                UNITY_DEFINE_INSTANCED_PROP( float4, _BorderColor2)
                UNITY_DEFINE_INSTANCED_PROP( float, _BorderColorNoiseScale)
                UNITY_DEFINE_INSTANCED_PROP( float, _BorderColorNoiseStrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _BorderFadeThickness)
                UNITY_DEFINE_INSTANCED_PROP( float, _FadeStartDelay)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
////// Lighting:
////// Emissive:
                float4 _BorderColor2_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BorderColor2 );
                float4 _BorderColor1_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BorderColor1 );
                float _BorderColorNoiseScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BorderColorNoiseScale );
                float2 node_2831 = (i.uv0*_BorderColorNoiseScale_var);
                float4 _BorderColorNoise_var = tex2D(_BorderColorNoise,TRANSFORM_TEX(node_2831, _BorderColorNoise));
                float _BorderColorNoiseStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BorderColorNoiseStrength );
                float4 _BaseColor_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BaseColor );
                float _NoiseScale_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseScale );
                float2 node_8397 = (i.uv0*_NoiseScale_var);
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(node_8397, _Noise));
                float _NoiseStrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _NoiseStrength );
                float node_2539 = (1.0 - (_Noise_var.r*_NoiseStrength_var));
                float _BorderFadeThickness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BorderFadeThickness );
                float node_1405 = (_BorderFadeThickness_var+node_2539);
                float4 node_8641 = _Time;
                float _StartTime_var = UNITY_ACCESS_INSTANCED_PROP( Props, _StartTime );
                float _FadeStartDelay_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeStartDelay );
                float _FadeSpeed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _FadeSpeed );
                float node_397 = (((node_8641.g-_StartTime_var)-_FadeStartDelay_var)*_FadeSpeed_var);
                float node_2459 = (1.0 - node_397);
                float3 emissive = lerp(lerp(_BorderColor2_var.rgb,_BorderColor1_var.rgb,saturate((_BorderColorNoise_var.r*_BorderColorNoiseStrength_var))),_BaseColor_var.rgb,smoothstep( node_2539, node_1405, node_2459 ));
                float3 finalColor = emissive;
                float _BorderThickness_var = UNITY_ACCESS_INSTANCED_PROP( Props, _BorderThickness );
                fixed4 finalRGBA = fixed4(finalColor,smoothstep( node_2539, node_1405, (node_2459+_BorderThickness_var) ));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
