namespace Tonestro.Maui.Kotlin.Parcelize.Runtime.UsageChecker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        Console.WriteLine($"ASDF: {typeof(Kotlinx.Parcelize.IIgnoredOnParcel).FullName}");
        Console.WriteLine($"ASDF: {typeof(Kotlinx.Android.Extensions.ILayoutContainer).FullName}");
        
        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}