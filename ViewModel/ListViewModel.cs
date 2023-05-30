using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTest.ViewModel
{
    partial class ListViewModel : ObservableObject
    {
        // $ read this to proceed with mvvm ListView...
        // https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/observableobject
        // https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/generators/observableproperty

        [ObservableProperty]
        List<string> names;

        

    }
}
