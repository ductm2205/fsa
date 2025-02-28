using System;
using System.Runtime.CompilerServices;

namespace vivustore.mvc.Models;

public class Customer : User
{
    public Customer()
    {
        ShippingAddresses = [];
    }

    public List<string> ShippingAddresses { get; set; }

    protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == nameof(Address) && !ShippingAddresses.Contains(propertyName))
        {
            ShippingAddresses.Add(propertyName);
        }
    }
}
