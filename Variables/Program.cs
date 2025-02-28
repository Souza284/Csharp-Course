#region Integer Numeric Types

//Integer signed: support negative numbers
sbyte num1 = 10; //8 bits (-128; 127)
short num2 = 20; //16 bits (-32.768; 32.767)
int num3 = 30; //32 bits (-2.147.483.648; 2.147.648.647)
long num4 = 40L; //64 bits (-9.223.372.036.854.775.808; 9.223.372.036.854.775.807)

// Integer not signed: do not support negative numbers
byte num5 = 10; //8 bits (0; 255)
ushort num6 = 20; //16 bits (0; 65.535)
uint num7 = 30; //32 bits (0; 4.294.967.295)
ulong num8 = 40L; //64 bits (0; 18.446.744.073.709.551.615) 

#endregion

#region Real Numeric Types

float real1 = 100.75F; //32 bits (7 digits precision)
double real2 = 12500.45; //64 bits (15 digits precision)
decimal real3 = 745353.457M; //128 bits (28 digits precision)

#endregion

#region Character Type

char letter = 'a'; //

#endregion

