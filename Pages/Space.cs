using System.Net.Http.Json;
using System.Threading.Tasks;

namespace todo_blazorwasm.Pages {
public partial class Space
{
    private const string method = "rest/launches";
    private launch[]? launches;

    protected override async Task OnInitializedAsync()
    {
        launches = await Http.GetFromJsonAsync<launch[]>(method);
    }
}
}