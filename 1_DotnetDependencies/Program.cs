using System.Net.NetworkInformation;
using Humanizer;

static void HumanizeQuantities()
{
  Console.WriteLine("fly".ToQuantity(0));
  Console.WriteLine("fly".ToQuantity(1));
  Console.WriteLine("fly".ToQuantity(5));
}

static void HumanizeDates()
{
  Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
  Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
  Console.WriteLine(TimeSpan.FromDays(1).Humanize());
  Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

