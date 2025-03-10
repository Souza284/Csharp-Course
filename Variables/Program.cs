﻿#region Integer Numeric Types

//Integer signed: support negative numbers
using Variables;

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

#region Bool Type

bool check = false;

#endregion

#region String Type

string text = "Pedro Souza Feres Kanaan";
string message = null;

#endregion

#region Object Type

object obj = 100;
object obj2 = "Pedro";
object obj3 = false;
object obj4 = new HttpClient();

#endregion

#region Const Type

const double pi = 3.14;
const string name = "Pedro";

#endregion

#region Enum Type

Grades grades = Grades.Minimum;

#endregion

#region Struct Type

Person p1 = new();

p1.name = "Pedro";
p1.age = 18;
p1.height = 1.73;

Person p2 = new()
{
    name = "Lorena",
    age = 17,
    height = 1.60
};

#endregion
