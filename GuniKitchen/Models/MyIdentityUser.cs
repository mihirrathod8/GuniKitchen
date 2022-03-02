using Microsoft.AspNetCore.Identity;
using System;

namespace GuniKitchen.Models
{
    public class MyIdentityUser
                            :IdentityUser<Guid>
    {
    }
}
