#region Implicit conversion

byte num1 = 110; //8 bits (0; 255)
ushort num2; //16 bits (0; 65.535)
float num3 = 1250.45f;
double num4 = num3;

num2 = num1; //ushort data can store byte

#endregion