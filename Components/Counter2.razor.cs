using Microsoft.AspNetCore.Components;

public partial class Counter2 {
    private int var2 = 0;
    [Parameter]
    public int var3 { get; set;}=1;

    public void clickFunction(){
        var2+=var3;
    }
}