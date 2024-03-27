using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

public class CsrfTokenService
{
    private readonly NavigationManager _navigationManager;

    public CsrfTokenService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public string GetCsrfToken()
    {
        var tokenElement = _navigationManager.Uri.Split(new[] { "__RequestVerificationToken" }, StringSplitOptions.None)[1];
        var token = tokenElement.Split(new[] { "\"" }, StringSplitOptions.None)[1];
        return token;
    }
}
