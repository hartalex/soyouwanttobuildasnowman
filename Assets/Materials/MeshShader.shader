// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:5970,x:32740,y:32602,varname:node_5970,prsc:2|diff-7413-OUT,normal-6993-OUT;n:type:ShaderForge.SFN_Tex2d,id:4257,x:32196,y:32662,ptovrint:False,ptlb:path albedo,ptin:_pathalbedo,varname:node_4257,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3738c589918108240bb02966b839f167,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7413,x:32396,y:32585,varname:node_7413,prsc:2|A-7311-OUT,B-4257-RGB,T-4463-OUT;n:type:ShaderForge.SFN_VertexColor,id:8299,x:31279,y:32617,varname:node_8299,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:335,x:31789,y:32514,ptovrint:False,ptlb:ice albedo,ptin:_icealbedo,varname:node_335,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:68a7e165943882344afd603a1a464e18,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7391,x:31170,y:32477,ptovrint:False,ptlb:snow albedo,ptin:_snowalbedo,varname:node_7391,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3277de7652880c545a28a81a31d4ea55,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7874,x:31405,y:32295,ptovrint:False,ptlb:rock albedo,ptin:_rockalbedo,varname:node_7874,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ff7d277dd30971c4d9160a9353c3c4d3,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7311,x:32196,y:32450,varname:node_7311,prsc:2|A-1668-OUT,B-335-RGB,T-9740-OUT;n:type:ShaderForge.SFN_Lerp,id:1668,x:31756,y:32305,varname:node_1668,prsc:2|A-7874-RGB,B-7391-RGB,T-5941-OUT;n:type:ShaderForge.SFN_Tex2d,id:7132,x:31378,y:32863,ptovrint:False,ptlb:rock normal,ptin:_rocknormal,varname:node_7132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:980ceac7efb8bc64e85220e5050647c5,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:6241,x:31378,y:33065,ptovrint:False,ptlb:snow normal,ptin:_snownormal,varname:node_6241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2194756113b0cb84fb9bc0b0a77c05ff,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Lerp,id:451,x:31784,y:32809,varname:node_451,prsc:2|A-7132-RGB,B-6241-RGB,T-5941-OUT;n:type:ShaderForge.SFN_Color,id:961,x:31784,y:32976,ptovrint:False,ptlb:ice normal,ptin:_icenormal,varname:node_961,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:0;n:type:ShaderForge.SFN_Lerp,id:4391,x:32123,y:32861,varname:node_4391,prsc:2|A-451-OUT,B-961-RGB,T-9740-OUT;n:type:ShaderForge.SFN_Tex2d,id:6913,x:32123,y:33016,ptovrint:False,ptlb:path normal,ptin:_pathnormal,varname:node_6913,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:284be24a76a762b46851e56e4fe33d27,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Lerp,id:6993,x:32420,y:32868,varname:node_6993,prsc:2|A-4391-OUT,B-6913-RGB,T-4463-OUT;n:type:ShaderForge.SFN_Tex2d,id:2330,x:31359,y:33269,ptovrint:False,ptlb:rock height,ptin:_rockheight,varname:node_2330,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:915e30c9a2499364889ff3e575f5f419,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9051,x:31378,y:33468,ptovrint:False,ptlb:snow height,ptin:_snowheight,varname:node_9051,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8a8e4b634208fab43a37bdc6e3ab2876,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:1851,x:31678,y:33564,ptovrint:False,ptlb:ice height,ptin:_iceheight,varname:node_1851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Tex2d,id:3273,x:32092,y:33459,ptovrint:False,ptlb:path height,ptin:_pathheight,varname:node_3273,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1ad921cf7635cb745b73ea4a1007f87c,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Step,id:5941,x:31797,y:33268,varname:node_5941,prsc:2|A-8698-OUT,B-2741-OUT;n:type:ShaderForge.SFN_Multiply,id:2741,x:31581,y:33371,varname:node_2741,prsc:2|A-9051-R,B-8299-G;n:type:ShaderForge.SFN_RemapRange,id:2661,x:31052,y:32901,varname:node_2661,prsc:2,frmn:0,frmx:1,tomn:1,tomx:0|IN-8299-G;n:type:ShaderForge.SFN_Multiply,id:2445,x:31869,y:33459,varname:node_2445,prsc:2|A-1851-R,B-8299-B;n:type:ShaderForge.SFN_Step,id:9740,x:32092,y:33297,varname:node_9740,prsc:2|A-5412-OUT,B-2445-OUT;n:type:ShaderForge.SFN_Add,id:5412,x:31836,y:33117,varname:node_5412,prsc:2|A-8698-OUT,B-2741-OUT;n:type:ShaderForge.SFN_Multiply,id:9883,x:32313,y:33392,varname:node_9883,prsc:2|A-3273-R,B-8299-R;n:type:ShaderForge.SFN_Step,id:4463,x:32471,y:33233,varname:node_4463,prsc:2|A-567-OUT,B-9883-OUT;n:type:ShaderForge.SFN_Add,id:567,x:32143,y:33169,varname:node_567,prsc:2|A-5412-OUT,B-2445-OUT;n:type:ShaderForge.SFN_RemapRange,id:9306,x:31065,y:32724,varname:node_9306,prsc:2,frmn:0,frmx:1,tomn:1,tomx:0|IN-8299-R;n:type:ShaderForge.SFN_RemapRange,id:4644,x:30910,y:32833,varname:node_4644,prsc:2,frmn:0,frmx:1,tomn:1,tomx:0|IN-8299-B;n:type:ShaderForge.SFN_Multiply,id:4615,x:31235,y:32762,varname:node_4615,prsc:2|A-4644-OUT,B-9306-OUT;n:type:ShaderForge.SFN_Multiply,id:6246,x:31182,y:33108,varname:node_6246,prsc:2|A-4615-OUT,B-2661-OUT;n:type:ShaderForge.SFN_Multiply,id:8698,x:31581,y:33194,varname:node_8698,prsc:2|A-6246-OUT,B-2330-R;proporder:4257-335-7391-7874-7132-6241-961-6913-2330-9051-1851-3273;pass:END;sub:END;*/

Shader "Custom/MeshShader" {
    Properties {
        _pathalbedo ("path albedo", 2D) = "black" {}
        _icealbedo ("ice albedo", 2D) = "white" {}
        _snowalbedo ("snow albedo", 2D) = "white" {}
        _rockalbedo ("rock albedo", 2D) = "white" {}
        _rocknormal ("rock normal", 2D) = "bump" {}
        _snownormal ("snow normal", 2D) = "bump" {}
        _icenormal ("ice normal", Color) = (0,0,0,0)
        _pathnormal ("path normal", 2D) = "bump" {}
        _rockheight ("rock height", 2D) = "white" {}
        _snowheight ("snow height", 2D) = "white" {}
        _iceheight ("ice height", Color) = (0,0,0,1)
        _pathheight ("path height", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _pathalbedo; uniform float4 _pathalbedo_ST;
            uniform sampler2D _icealbedo; uniform float4 _icealbedo_ST;
            uniform sampler2D _snowalbedo; uniform float4 _snowalbedo_ST;
            uniform sampler2D _rockalbedo; uniform float4 _rockalbedo_ST;
            uniform sampler2D _rocknormal; uniform float4 _rocknormal_ST;
            uniform sampler2D _snownormal; uniform float4 _snownormal_ST;
            uniform float4 _icenormal;
            uniform sampler2D _pathnormal; uniform float4 _pathnormal_ST;
            uniform sampler2D _rockheight; uniform float4 _rockheight_ST;
            uniform sampler2D _snowheight; uniform float4 _snowheight_ST;
            uniform float4 _iceheight;
            uniform sampler2D _pathheight; uniform float4 _pathheight_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _rocknormal_var = UnpackNormal(tex2D(_rocknormal,TRANSFORM_TEX(i.uv0, _rocknormal)));
                float3 _snownormal_var = UnpackNormal(tex2D(_snownormal,TRANSFORM_TEX(i.uv0, _snownormal)));
                float node_6246 = (((i.vertexColor.b*-1.0+1.0)*(i.vertexColor.r*-1.0+1.0))*(i.vertexColor.g*-1.0+1.0));
                float4 _rockheight_var = tex2D(_rockheight,TRANSFORM_TEX(i.uv0, _rockheight));
                float node_8698 = (node_6246*_rockheight_var.r);
                float4 _snowheight_var = tex2D(_snowheight,TRANSFORM_TEX(i.uv0, _snowheight));
                float node_2741 = (_snowheight_var.r*i.vertexColor.g);
                float node_5941 = step(node_8698,node_2741);
                float node_5412 = (node_8698+node_2741);
                float node_2445 = (_iceheight.r*i.vertexColor.b);
                float node_9740 = step(node_5412,node_2445);
                float3 _pathnormal_var = UnpackNormal(tex2D(_pathnormal,TRANSFORM_TEX(i.uv0, _pathnormal)));
                float4 _pathheight_var = tex2D(_pathheight,TRANSFORM_TEX(i.uv0, _pathheight));
                float node_4463 = step((node_5412+node_2445),(_pathheight_var.r*i.vertexColor.r));
                float3 normalLocal = lerp(lerp(lerp(_rocknormal_var.rgb,_snownormal_var.rgb,node_5941),_icenormal.rgb,node_9740),_pathnormal_var.rgb,node_4463);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _rockalbedo_var = tex2D(_rockalbedo,TRANSFORM_TEX(i.uv0, _rockalbedo));
                float4 _snowalbedo_var = tex2D(_snowalbedo,TRANSFORM_TEX(i.uv0, _snowalbedo));
                float4 _icealbedo_var = tex2D(_icealbedo,TRANSFORM_TEX(i.uv0, _icealbedo));
                float4 _pathalbedo_var = tex2D(_pathalbedo,TRANSFORM_TEX(i.uv0, _pathalbedo));
                float3 diffuseColor = lerp(lerp(lerp(_rockalbedo_var.rgb,_snowalbedo_var.rgb,node_5941),_icealbedo_var.rgb,node_9740),_pathalbedo_var.rgb,node_4463);
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _pathalbedo; uniform float4 _pathalbedo_ST;
            uniform sampler2D _icealbedo; uniform float4 _icealbedo_ST;
            uniform sampler2D _snowalbedo; uniform float4 _snowalbedo_ST;
            uniform sampler2D _rockalbedo; uniform float4 _rockalbedo_ST;
            uniform sampler2D _rocknormal; uniform float4 _rocknormal_ST;
            uniform sampler2D _snownormal; uniform float4 _snownormal_ST;
            uniform float4 _icenormal;
            uniform sampler2D _pathnormal; uniform float4 _pathnormal_ST;
            uniform sampler2D _rockheight; uniform float4 _rockheight_ST;
            uniform sampler2D _snowheight; uniform float4 _snowheight_ST;
            uniform float4 _iceheight;
            uniform sampler2D _pathheight; uniform float4 _pathheight_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _rocknormal_var = UnpackNormal(tex2D(_rocknormal,TRANSFORM_TEX(i.uv0, _rocknormal)));
                float3 _snownormal_var = UnpackNormal(tex2D(_snownormal,TRANSFORM_TEX(i.uv0, _snownormal)));
                float node_6246 = (((i.vertexColor.b*-1.0+1.0)*(i.vertexColor.r*-1.0+1.0))*(i.vertexColor.g*-1.0+1.0));
                float4 _rockheight_var = tex2D(_rockheight,TRANSFORM_TEX(i.uv0, _rockheight));
                float node_8698 = (node_6246*_rockheight_var.r);
                float4 _snowheight_var = tex2D(_snowheight,TRANSFORM_TEX(i.uv0, _snowheight));
                float node_2741 = (_snowheight_var.r*i.vertexColor.g);
                float node_5941 = step(node_8698,node_2741);
                float node_5412 = (node_8698+node_2741);
                float node_2445 = (_iceheight.r*i.vertexColor.b);
                float node_9740 = step(node_5412,node_2445);
                float3 _pathnormal_var = UnpackNormal(tex2D(_pathnormal,TRANSFORM_TEX(i.uv0, _pathnormal)));
                float4 _pathheight_var = tex2D(_pathheight,TRANSFORM_TEX(i.uv0, _pathheight));
                float node_4463 = step((node_5412+node_2445),(_pathheight_var.r*i.vertexColor.r));
                float3 normalLocal = lerp(lerp(lerp(_rocknormal_var.rgb,_snownormal_var.rgb,node_5941),_icenormal.rgb,node_9740),_pathnormal_var.rgb,node_4463);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _rockalbedo_var = tex2D(_rockalbedo,TRANSFORM_TEX(i.uv0, _rockalbedo));
                float4 _snowalbedo_var = tex2D(_snowalbedo,TRANSFORM_TEX(i.uv0, _snowalbedo));
                float4 _icealbedo_var = tex2D(_icealbedo,TRANSFORM_TEX(i.uv0, _icealbedo));
                float4 _pathalbedo_var = tex2D(_pathalbedo,TRANSFORM_TEX(i.uv0, _pathalbedo));
                float3 diffuseColor = lerp(lerp(lerp(_rockalbedo_var.rgb,_snowalbedo_var.rgb,node_5941),_icealbedo_var.rgb,node_9740),_pathalbedo_var.rgb,node_4463);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
