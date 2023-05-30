using CommunityToolkit.Mvvm.ComponentModel;
using ListViewTest.ViewModel;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ListViewTest;

public partial class MainPage : ContentPage
{
    //int count = 0;

    //List<string> lstTest = new();
    ObservableCollection<string> ocList = new();

    public MainPage()
	{
		InitializeComponent();

        //lstTest.Add("string1");

        lstListView.ItemsSource = ocList;

        //ListViewModel lvm = new();

        //lvm.Names = new(); // $ declare when and where?
        //lvm.Names.Add("buddy garrity");
        //lvm.Names.Add("jason priestley");
        //lvm.Names.Add("luke perry");

        //lstListView2.ItemsSource = lvm.Names;
    }

    private void btnAddLine_Clicked(object sender, EventArgs e)
    {
        ocList.Add("new line");
    }

    private void btnClear_Clicked(object sender, EventArgs e)
    {
        ocList.Clear();
    }
}

