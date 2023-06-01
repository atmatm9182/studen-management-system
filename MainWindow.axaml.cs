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
    private readonly StudentsContext _db = new StudentsContext();

    public event PropertyChangedEventHandler? PropertyChanged;

    public void AddStudentButtonClicked()
    {
    }

}