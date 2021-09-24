﻿using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BookMyShow
{
	class Program
	{
		static void Main(string[] args)

		{

			//Creating instance for ExcelReadWriteCreate class
			//ExcelReadWriteCreate Erw = new ExcelReadWriteCreate();

			//Erw.WriteDataToExcel();   //Calling function for writing data in excel

			string path = @"E:\selenium\BookMyShow\cities.xls";
			//Worksheet sheet = null;

			//if (!File.Exists(path))
			//{
				//sheet = Erw.WriteDataToExcel();
			//}


			//TextFileWriteRead Twr = new TextFileWriteRead();
			//Twr.DirectoryOperation();

			IWebDriver driver = new ChromeDriver("E:\\selenium\\chromedriver");
			//Maximize the browser
			driver.Manage().Window.Maximize();
			//Launch Url(Open Google
			driver.Url = @"https://in.bookmyshow.com/";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
			// WorkBook->Sheet->Row->Cell
			//.xls -> HSSF
			//foreach (string cell_value in ReadDataFromExcel(path))
			//{
				//Console.WriteLine(cell_value);
			//}
			//Thread.Sleep(3000);
			IWebElement notification_box = driver.FindElement(By.Id("wzrk-confirm"));
			if (notification_box.Displayed)
			{
				notification_box.Click();
			}
			driver.FindElement(By.CssSelector("input.sc-bqjOQT")).SendKeys("Nashik");
			Thread.Sleep(3000);
			Actions action = new Actions(driver);

			Thread.Sleep(3000);
			IWebElement search_box = driver.FindElement(By.CssSelector("input.sc-bqjOQT"));
			action.MoveToElement(search_box).Click().Perform();
			driver.FindElement(By.TagName("Body")).SendKeys(Keys.Enter);
			driver.FindElement(By.CssSelector("li.sc-cpHetk")).Click();
			driver.FindElement(By.Id("4")).Click();
			driver.FindElement(By.CssSelector("input.sc-bqjOQT")).SendKeys("Shersh");
			Thread.Sleep(2000);
			driver.FindElement(By.CssSelector("li.sc-cpHetk")).Click();
			String about_Movie = driver.FindElement(By.CssSelector("div.styles__DescriptionContainer-sc-o4g232-3")).Text;
			Console.WriteLine(about_Movie);
			driver.Quit();
		}


	}
}

















//launch chrome
//IWebDriver driver = new ChromeDriver("E:\\selenium\\chromedriver");
// driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
//Maximize the browser
//to launch the website
//driver.Url = @"https://in.bookmyshow.com/explore/home/chennai";
//driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/header/div[1]/div/div/div/div[2]/div[2]/div[1]")).Click();

//driver.FindElement(By.XPath("//*[@id=\"wzrk-cancel\"]")).Click();
//String strFile = "data1.xls";
//string path = @"E:\selenium\Final_Project\data1.xlsx";

// Instantiate a Workbook object that represents Excel file.
//Workbook wb = new Workbook(path);
//Worksheet sheet = wb.Worksheet[0];
//driver.FindElement(By.XPath("//*[@id=\"modal-root\"]/div/div/div/div[1]/div/div/input")).SendKeys(st);
//driver.FindElement(By.XPath("//*[@id=\"modal-root\"]/div/div/div/div[1]/div[1]/div[1]/input")).SendKeys(Keys.Enter);
//Go to the movies tab
//driver.FindElement(By.XPath("//*[@id=\'super-container\']/div[2]/header/div[2]/div/div/div/div[1]/div/a[1]")).Click();
//Go to explore upcoming movies
//driver.findElement(By.xpath("//*[@id=\'super-container\']/div[2]/div[4]/div[2]/div[2]/div/div/div[2]/a/div/div[2]/div/img")).click();
//driver.FindElement(By.XPath("//*[@id=\"super-container\"]/div[2]/div[4]/div[2]/div[3]/div/div/div[2]/a/div/div[2]/div/img")).Click();
//Click on the first movie in the list
//driver.FindElement(By.XPath("//*[@id=\"super-container\"]/div[2]/div[3]/div[2]/div[4]/div/div/div[2]/a[2]/div/div[2]/div/img")).Click();
//Writing movie name on the Console
//Console.WriteLine("City :- " + st);
//Writing movie name in the text file
//fw.Write("City Search :-" + st);
//To get the movie name
//string movieName = driver.FindElement(By.XPath("//*[@id=\"super-container\"]/div[2]/section[1]/div/div/div[2]/h1")).getText();
//To write the movie name in text file
//fw.Write("\n" + movieName + " - Pass");
//To print movie name in console
//Console.WriteLine(movieName);
//About the movie in console
//Console.WriteLine("About the movie:-");
//Fetching data from webpage and printing it on console
//Console.WriteLine(driver.FindElement(By.XPath("//*[@id=\"component-1\"]/section/span/div/span")).getText());
//Fetching data from webpage and printing it in text file
//string info = driver.FindElement(By.XPath("//*[@id=\"component-1\"]/section/span/div/span")).getText();
//fw.Write("\n" + info);
//fw.Close();


//ring FileExtension = ".txt";

// driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/header/div[1]/div/div/div/div[2]/div[2]/div[1]")).Click();

//driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/header/div[1]/div/div/div/div[2]/div[1]/span")).Click();
// Thread.Sleep(4000);
//driver.FindElement(By.XPath("/html/body/div[5]/div[2]/div[3]/button[2]")).Click();
//driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/div/input")).SendKeys("Pune");





