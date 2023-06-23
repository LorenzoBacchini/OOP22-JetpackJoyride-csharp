﻿using System;
using System.IO;
using System.Collections.Generic;
using AnnibaliniLorenzo.JetpackJoyride.Point2d;
using AnnibaliniLorenzo.JetpackJoyride.Vector2d;
using BurreliMattia.JetpackJoyride.Api.Hitbox;
using BurreliMattia.JetpackJoyride.Impl.HitboxImpl;
using BacchiniLorenzo.JetpackJoyride.Api;

namespace BacchiniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// A class to load money from file.
/// @author lorenzo.bacchini4@studio.unibo.it
/// </summary>
public class MoneyPatternLoaderImpl : IMoneyPatternLoader
{
    //Order to read data from nextLine().
    private const int X = 0;
    private const int Y = 0;
    
    private const int Limit = 395;
    
    /*
     * Attribute that count the number of available pattern file.
     * N.B the number of available file must be the same of the number
     * of file money_.txt in the resources folder.
     */
    private readonly int _availableFile;
    private readonly int _minAvailableFile;
    private const string Filename = "/money";
    private const int Nfile = 4;
    //Range to change the y coordinate of the money.
    private const int Range = 150;
    //Random to multiply the range
    private const int Minrandom = -1;
    private const int Maxrandom = 1;

    /// <summary>
    /// Constructor of the class MoneyPatternLoader.
    /// Normal Constructor, the programmer set the minAvailableFile
    /// and the availableFile.
    /// </summary>
    /// <exception cref="IllegalArgumentException">
    /// if the number of available file
    /// is less than the minimum number of available file.
    /// </exception>
    public MoneyPatternLoaderImpl()
    {
        _availableFile = Nfile;
        _minAvailableFile = 1;
        if (_availableFile < _minAvailableFile)
        {
            throw new ArgumentException(
                "The number of available file is less than the minimum number of available file.");
        }
    }
    
    /// <summary>
    /// Constructor of the class MoneyPatternLoader.
    /// Specific Constructor to set the number of the
    /// unique(1 file) available file.
    /// </summary>
    /// <param name="num">
    /// the number of the available file.
    /// </param>>
    public MoneyPatternLoaderImpl(int num)
    {
        _minAvailableFile = num;
        _availableFile = num;
    }

    public List<Money> GetMoneyPattern()
    {
        Random rnd = new Random();
        string fileNumber;
        fileNumber = rnd.Next(_minAvailableFile, _availableFile + 1).ToString();
        string[] lines;
        try 
        {
            lines = File.ReadAllLines(Filename);
        }
        catch (IOException e)
        {
            throw new InvalidOperationException("Error while reading Money Pattern " + fileNumber + "file", e);
        }
        
        List<Money> moneyList = new List<Money>();
        double multiplier = rnd.Next(Minrandom, Maxrandom + 1);
        foreach (string line in lines)
        {
            int x = int.Parse(line.Split(",")[X]);
            int y = int.Parse(line.Split(",")[Y]);
            y = y + (int)(multiplier * Range);
            Point2d startPosition = new Point2d(x, y);
            Point2d finishPosition = new Point2d(x - Limit, startPosition.GetY());
            Vector2d vec = new Vector2d(finishPosition, startPosition);
            Hitbox hitbox = new HitboxImpl(15.0, 15.0, startPosition);
            moneyList.Add(new Money(startPosition, vec, hitbox));
        }

        return moneyList;
    }
}