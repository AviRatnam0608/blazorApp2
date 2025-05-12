using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace blazorApp2.Components {
    public partial class NavBar {
        public string randomImgUrl {get; set; }
        public string randomImgName {get; set; }
        public int id {get; set;}

        public void getRandomImg(){
             randomImgUrl = "https://picsum.photos/200";
        }
    }
}