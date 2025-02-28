using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace vivustore.mvc.Models;

public class User : BaseEntity, INotifyPropertyChanged
{

    [Required]
    [StringLength(12)]
    public required string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    private string _address;


    [Required]
    public required string Address
    {
        get => _address;
        set
        {
            if (_address != value)
            {
                _address = value;
                OnPropertyChanged();
            }
        }
    }

    [Required]
    [StringLength(12)]
    public required string PhoneNumber { get; set; }

    [Required]
    [StringLength(12)]
    public required string Email { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
