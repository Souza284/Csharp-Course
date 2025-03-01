#region Implicit conversion

byte num1 = 110; //8 bits (0; 255)
ushort num2; //16 bits (0; 65.535)
float num3 = 1250.45f;
double num4 = num3;

num2 = num1; //ushort data can store byte

#endregion

#region Explicit conversion

ushort num5 = 100;
byte num6 = (byte)num5;

float num7 = 2500.85f;
int num8 = (int)num7;

#endregion

#region Parse method

string txtNumber = "198";

int number = Int32.Parse(txtNumber);

byte num9 = byte.Parse(txtNumber);

System.Console.WriteLine(num9);

#endregion

#region Class Convert

string text = Convert.ToString(true);

bool boolValue = Convert.ToBoolean(-123);

System.Console.WriteLine(boolValue);

#endregion
