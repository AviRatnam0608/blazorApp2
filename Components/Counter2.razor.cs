using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace blazorApp2.Components {
    public partial class Counter2 { // partial class since it technically merges this with the class in Counter2.razor (@code section)
        public int currentValue { get; set; } = 0;
        [Parameter]
        public int var3 { get; set;} = 1;
        public string outputText { get; set; }
        public bool showDivText { get; set; } = false;
        public string? resultText { get; set; }

        public void clickFunction(){
            currentValue+=var3;
        }
        public void HandleInput(ChangeEventArgs e) {
            outputText = (string)e.Value!;
        }
        public void MouseOver(MouseEventArgs e) {
            showDivText = !showDivText;
        }

        public async Task SearchResult(){
            await Task.Delay(3000);
            resultText = "Found 100 results";
        }
    }
}