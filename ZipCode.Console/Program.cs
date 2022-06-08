using ZipCode.Core.Entities;
using ZipCode.RepositoryEfMySql;
using System;
using System.Xml;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string path;
List<string> lineas;
Repository zipCodeRepository;

path = "/home/vmartinez/Downloads/CodigosPostales.txt";
lineas = File.ReadAllLines(path,System.Text.Encoding.Latin1).ToList();
// zipCodeRepository = new Repository(new ZipCode.RepositoryEfMySql.Contexts.AppDbContext());
// for (int i = 2; i < lineas.Count(); i++)
// {
//     var item = lineas[i];
//     var array = item.Split("|");
//     ZipCodeEntity zipCode;

//     zipCode = new ZipCodeEntity
//     {
//         ZipCode = array[0],
//         Settement = array[1],
//         SettementType = array[2],
//         Municipality = array[3],
//         City = array[4],
//         State = array[6]
//     };
//     _ = zipCodeRepository.AddSync(zipCode).Result;
//     Console.WriteLine(zipCode.ZipCode);
// }
Console.WriteLine("Proceso finalizado");