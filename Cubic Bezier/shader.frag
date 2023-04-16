#version 110

varying vec3 fragPos;
varying vec3 objColor;
varying vec3 normVectorRotated;

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

void main(void) {
	if(lightType == 0){
		vec3 ambient = ambientStrength * lightColor;

		vec3 norm = normalize(normVectorRotated);
		vec3 lightDir = normalize(lightPos1 - fragPos);
		float diff = max(dot(norm, lightDir), 0.0);
		vec3 diffuse = diffuseStrength * diff * lightColor;

		vec3 viewDir = normalize(viewPos1 - fragPos);
		vec3 reflectDir = reflect(-lightDir, norm);
		float spec = pow(max(dot(viewDir, reflectDir), 0.0), shininess);
		vec3 specular = specularStrength * spec * lightColor;

		if(!isAmbient) ambient = vec3(0.0, 0.0, 0.0);
		if(!isDiffuse) diffuse = vec3(0.0, 0.0, 0.0);
		if(!isSpecular || diff <= 0) specular = vec3(0.0, 0.0, 0.0);
		vec3 resCol = (ambient + diffuse + specular) * objColor;
		gl_FragColor = vec4(resCol, 1.0);
	}
}
