using Microsoft.AspNetCore.Components;

namespace blazorApp2.Components {
    public partial class Counter2 { // partial class since it technically merges this with the class in Counter2.razor (@code section)
        public int currentValue { get; set; } = 0;
        [Parameter]
        public int var3 { get; set;} = 1;

        public void clickFunction(){
            currentValue+=var3;
        }
    }
}