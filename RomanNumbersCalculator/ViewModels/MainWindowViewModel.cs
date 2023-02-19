using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using DynamicData;
using ReactiveUI;
using RomanNumbersCalculator.Models;
using RomanNumbersCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Security.Cryptography;
using System.Text;

namespace RomanNumbersCalculator.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        string currentNumberStringRepresentation = "";
        string currentOperationStringRepresentation = "";
        Stack<RomanNumberExtend> StackRomanNumbers = new Stack<RomanNumberExtend>();
        public MainWindowViewModel()
        {
            //AddNumber = ReactiveCommand.Create<string, Unit>(str => { str = ""; return Unit.Default; });
            AddNumber = ReactiveCommand.Create<string>(str =>
            {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentOperationStringRepresentation == "=")
                    {
                        CurrentOperationStringRepresentation = "";
                        CurrentNumberStringRepresentation = "";
                        StackRomanNumbers.Clear();
                    }
                    CurrentNumberStringRepresentation += str;
                }
                else
                {
                    CurrentNumberStringRepresentation = str;
                }
                //return Unit.Default;
            });
            PlusCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "")
                    {
                        if (currentOperationStringRepresentation != "")
                        {
                            currentOperationStringRepresentation = "+";
                        }
                        return;
                    }
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "+";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "+";
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(newNumber);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                                        break;
                                }
                                currentOperationStringRepresentation = "+";
                                CurrentNumberStringRepresentation = "";
                            }
                        }
                    }

                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }

            });
            SubCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "")
                    {
                        if (currentOperationStringRepresentation != "")
                        {
                            currentOperationStringRepresentation = "-";
                        }
                        return;
                    }
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "-";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "-";
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(newNumber);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                                        break;
                                }
                                currentOperationStringRepresentation = "-";
                                CurrentNumberStringRepresentation = "";
                            }
                        }
                    }

                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }


            });
            MulCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "")
                    {
                        if (currentOperationStringRepresentation != "")
                        {
                            currentOperationStringRepresentation = "*";
                        }
                        return;
                    }
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "*";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "*";
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(newNumber);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                                        break;
                                }
                                currentOperationStringRepresentation = "*";
                                CurrentNumberStringRepresentation = "";
                            }
                        }
                    }

                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }


            });
            DivCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "")
                    {
                        if (currentOperationStringRepresentation != "")
                        {
                            currentOperationStringRepresentation = "/";
                        }
                        return;
                    }
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "/";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "/";
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(newNumber);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                                        break;
                                }
                                currentOperationStringRepresentation = "/";
                                CurrentNumberStringRepresentation = "";
                            }
                        }
                    }

                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }


            });
            CalculateCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "" || currentOperationStringRepresentation == "")
                    {
                        return;
                    }
                    try
                    {
                        RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                        switch (currentOperationStringRepresentation)
                        {
                            case "+":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                                break;
                            case "-":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                                break;
                            case "*":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                                break;
                            case "/":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                                break;
                        }
                        newNumber = StackRomanNumbers.Pop();
                        CurrentNumberStringRepresentation = newNumber.ToString();
                        StackRomanNumbers.Push(newNumber);
                        CurrentOperationStringRepresentation = "=";
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                        CurrentOperationStringRepresentation = "";
                        StackRomanNumbers.Clear();
                    }
                }


            });
            ResetCommand = ReactiveCommand.Create(() => {
                CurrentOperationStringRepresentation = "";
                CurrentNumberStringRepresentation = "";
                StackRomanNumbers.Clear();
            });
        }
        private string CurrentNumberStringRepresentation
        {
            get => currentNumberStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value);
            }

        }
        private string CurrentOperationStringRepresentation
        {
            get => currentOperationStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentOperationStringRepresentation, value);


            }
        }
        public ReactiveCommand<string, Unit> AddNumber { get; }
        public ReactiveCommand<Unit, Unit> PlusCommand { get; }
        public ReactiveCommand<Unit, Unit> SubCommand { get; }
        public ReactiveCommand<Unit, Unit> MulCommand { get; }
        public ReactiveCommand<Unit, Unit> DivCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
        public ReactiveCommand<Unit, Unit> ResetCommand { get; }
    }
}
