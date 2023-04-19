#version 110

varying vec3 fragPos;
varying vec3 objColor;
varying vec3 normVectorRotated;
varying vec3 lightDest1;

uniform vec3 lightColor;
varying vec3 lightPos1;
varying vec3 viewPos1;
uniform bool isAmbient;
uniform bool isDiffuse;
uniform bool isSpecular;
uniform float ambientStrength;
uniform float diffuseStrength;
uniform float specularStrength;
uniform float shininess;
uniform float lightType;
uniform float lightAngle;
uniform vec3 emissionColor;
uniform vec3 attenuation;

void main(void) {
		vec3 ambient = ambientStrength * lightColor;

		vec3 lightVec = normalize(lightDest1-lightPos1);
		vec3 norm = normalize(normVectorRotated);
		vec3 lightDir = normalize(lightPos1 - fragPos);
		if(lightType == 2) lightDir = -lightVec;
		float diff = max(dot(norm, lightDir), 0.0);
		vec3 diffuse = diffuseStrength * diff * lightColor;

		vec3 viewDir = normalize(viewPos1 - fragPos);
		vec3 reflectDir = reflect(-lightDir, norm);
		float spec = pow(max(dot(viewDir, reflectDir), 0.0), shininess);
		vec3 specular = specularStrength * spec * lightColor;

		float dist = length(lightPos1 - fragPos);
		float attenuationCoef = 1.0 / (attenuation.x + attenuation.y * dist + attenuation.z * dist * dist);
		if(lightType == 2) attenuationCoef = 1.0;

		vec3 lightColorProj = vec3(0.0);
		bool inCone = (1>0);
		if(lightType == 1){
			float cosAngle = dot(lightDir, -lightVec);
			float angleThreshold = cos(lightAngle);
			inCone = cosAngle >= angleThreshold;
			if (inCone && diff > 0) {
				lightColorProj = (cosAngle - angleThreshold) / (1.0 - angleThreshold) * lightColor;
			}
		}

		if(!isAmbient) ambient = vec3(0.0, 0.0, 0.0);
		if(!isDiffuse || !inCone) diffuse = vec3(0.0, 0.0, 0.0);
		if(!isSpecular || diff <= 0 || !inCone) specular = vec3(0.0, 0.0, 0.0);

		vec3 resCol = ((ambient + (diffuse + specular) * attenuationCoef) * (1.0 - lightColorProj) + lightColorProj * attenuationCoef) * objColor + emissionColor;
		gl_FragColor = vec4(resCol, 1.0);
}
