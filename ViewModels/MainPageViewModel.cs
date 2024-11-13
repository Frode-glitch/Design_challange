using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Handlers.Items;

namespace Design_challenge
{
    
    public class Deal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Header { get; set; }
        public int Id { get; set; }
    }
}
