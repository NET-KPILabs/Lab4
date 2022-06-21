﻿using Lab4;
using Lab4.Helpers;
using Lab4.Producers;

var exellioProducer = new ExellioProducer();
var exellioCashRegister = new CashRegister(exellioProducer);
exellioCashRegister.AddProduct(DataHelper.GetRandomProduct());
exellioCashRegister.AddProduct(DataHelper.GetRandomProduct());
exellioCashRegister.SaveCheck();
Console.WriteLine(exellioCashRegister.PrintCheck());
Console.WriteLine();

var smartKasaProducer = new SmartKasaProducer();
var smartKasaCashRegister = new CashRegister(smartKasaProducer);
smartKasaCashRegister.AddProduct(DataHelper.GetRandomProduct());
smartKasaCashRegister.AddProduct(DataHelper.GetRandomProduct());
smartKasaCashRegister.AddProduct(DataHelper.GetRandomProduct());
smartKasaCashRegister.SaveCheck();
Console.WriteLine(smartKasaCashRegister.PrintCheck());

