// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Math math = new Math(); // static olduğu için instance alınamaz

//using StaticClassSample;

//double num = Math.Pow(3, 5);
//double pi = Math.PI;

//Physics.Gravity = 9.81M; // set methodu ile property'e değer atadık
//Console.WriteLine(Physics.Gravity); // get methodu ile property'nin değerine ulaştık
//int buoyancyOfWater = Physics.BuoyancyOfWater; // const olarak tanımlanan field değişkenlere ilk sefer haricinde atama yapılamaz
////Physics.force = 15; // readonly bir field'a ancak static constrctor'da veya değişken initializer'da değer atanabilir    
//Physics.UseBuoyancyOfWater();

using StaticClassSample;

string str = " BugÜn   on  Üç hazİRan iki BiN yirMi dÖrt Perşembe";

//string newStr = ExtentionMethod.ChangeTurkishCharacters(str); // bu şekilde de çağırabilirim
string newStr = str.ChangeTurkishCharacters(); // bir string methodu gibi çağırıyorum
Console.WriteLine(newStr);