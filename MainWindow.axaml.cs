using System;
using System.Collections.Generic;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Sem2Project;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}

public class MainWindowViewModel : INotifyPropertyChanged
{
    private string _firstNameInputText;
    private string _lastNameInputText;
    private string _albumNumber;
    private string _errorLabelText;
    
    private readonly StudentsContext _db = new StudentsContext();

    public event PropertyChangedEventHandler? PropertyChanged;

    public void AddStudentButtonClicked()
    {
    }

    public string FirstNameInputText
    {
        get => _firstNameInputText;
        set
        {
            _firstNameInputText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstNameInputText)));
        }
    }
    
    public string LastNameInputText
    {
        get => _lastNameInputText;
        set
        {
            _lastNameInputText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastNameInputText)));
        }
    }

    public string AlbumNumber
    {
        get => _albumNumber;
        set
        {
            _albumNumber = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AlbumNumber)));
        }
    }
    
    public string ErrorLabelText 
    {
        get => _errorLabelText;
        set
        {
            _errorLabelText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ErrorLabelText)));
        }
    }
}