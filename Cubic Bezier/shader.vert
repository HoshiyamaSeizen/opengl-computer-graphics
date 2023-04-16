#version 110

attribute vec3 position;
attribute vec3 normVector;

uniform float t;
uniform bool animation;
uniform mat4 lookAtMatrix;
uniform vec3 lightPos;
uniform vec3 viewPos;

varying vec3 lightPos1;
varying vec3 viewPos1;
varying vec3 objColor;
varying vec3 fragPos;
varying vec3 normVectorRotated;

void main(void) {
	float yCoord = animation ? sin(0.4 * gl_Vertex.x + t) * gl_Vertex.x * 0.05 : 0;
	vec4 pos = gl_Vertex + vec4(0.0, yCoord, 0.0, 0.0);
    gl_Position = gl_ModelViewProjectionMatrix * pos;

	fragPos = (gl_ModelViewMatrix * pos).xyz;
	if(normVector.x == 0 && normVector.y == 0 && normVector.z == 0) normVectorRotated = gl_NormalMatrix * gl_Normal;
	else normVectorRotated = gl_NormalMatrix * normVector;
	objColor = gl_Color.rgb;
	lightPos1 = (lookAtMatrix * vec4(lightPos, 1.0)).xyz;
	viewPos1 = (lookAtMatrix * vec4(viewPos, 1.0)).xyz;
}
