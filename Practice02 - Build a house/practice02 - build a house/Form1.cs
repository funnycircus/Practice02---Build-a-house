using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LetsBuildAHouse;

namespace Practice02___Build_a_house
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        //first floor
        //RoomWithDoor 客廳;
        RoomWithDoorAndStair 客廳;
        Room 餐廳;
        RoomWithDoor 廚房;
        OutsideWithDoor 前院;
        OutsideWithDoor 後院;
        Outside 花圃;

        //second floor
        RoomWithDoor 主臥室;
        Room 主臥浴室;
        Room 書房;
        Room 客人浴室;
        OutsideWithDoor 前陽台;
        OutsideWithDoor 後陽台;
        Outside 空中花園;
        //AisleWithDoor 走道;
        AisleWithDoorAndStair 走道;

        
        public Form1()
        {
            InitializeComponent();
            建立所有區域();
            走去(客廳);
        }

        private void 建立所有區域()
        {

            //create first floor
            //客廳 = new RoomWithDoor("豪華的客廳", "65吋大電視，豪華大沙發", "可以通往前院的門");
            //建立有樓梯的客廳
            客廳 = new RoomWithDoorAndStair("豪華的客廳", "65吋大電視，豪華大沙發", "可以通往前院的門", "可以通往二樓的樓梯");
            餐廳 = new Room("溫馨的餐廳","大餐桌，烤箱，大冰箱");
            廚房 = new RoomWithDoor("實用的廚房", "爐子，微波爐，洗碗機", "可以通往後院的門");
            前院 = new OutsideWithDoor("前院", true, "可以回客廳的門");
            後院 = new OutsideWithDoor("後院", true, "可以回廚房的門");
            花圃 = new Outside("美麗的花園",true);
            
            
            

            //create second floor
            主臥室 = new RoomWithDoor("豪華的主臥室", "65吋大電視，豪華大床", "可以通往前陽台的門");
            主臥浴室 = new Room("主臥的浴室", "大浴缸");
            客人浴室 = new Room("客人的浴室", "淋浴間");
            書房 = new Room("工作用書房", "電腦很多台");
            前陽台 = new OutsideWithDoor("前陽台", true, "可以回主臥室的門");
            後陽台 = new OutsideWithDoor("後陽台", true, "可以回走道的門");
            空中花園 = new Outside("美麗的空中花園", true);
            //走道 = new AisleWithDoor("二樓走道", "壁掛繪畫作裝飾", "可以通往後陽台的門");
            //建立有樓梯的走道
            走道 = new AisleWithDoorAndStair("二樓走道", "壁掛繪畫作裝飾", "可以通往後陽台的門", "可以通往一樓的樓梯");
            
            //一樓布局
            客廳.Exits = new Location[] { 前院, 餐廳, 走道 };
            客廳.DoorLocation = 前院;
            客廳.StairLocation = 走道;
            餐廳.Exits = new Location[] { 客廳, 廚房 };
            廚房.Exits = new Location[] { 後院, 餐廳 };
            廚房.DoorLocation = 後院;

            前院.Exits = new Location[] { 客廳, 花圃 };
            前院.DoorLocation = 客廳;

            後院.Exits = new Location[] { 廚房, 花圃 };
            後院.DoorLocation = 廚房;

            花圃.Exits = new Location[] { 前院, 後院 };

            //二樓布局
            主臥室.Exits = new Location[] { 前陽台, 主臥浴室, 走道 };
            主臥室.DoorLocation = 前陽台;
            主臥浴室.Exits = new Location[] { 主臥室 };
            書房.Exits = new Location[] { 走道 };
            客人浴室.Exits = new Location[] { 走道 };
            走道.Exits = new Location[] { 主臥室, 客廳, 書房, 客人浴室, 後陽台 };
            走道.DoorLocation = 後陽台;
            走道.StairLocation = 客廳;

            前陽台.Exits = new Location[] { 主臥室, 空中花園 };
            前陽台.DoorLocation = 主臥室;

            後陽台.Exits = new Location[] { 走道, 空中花園 };
            後陽台.DoorLocation = 走道;

            空中花園.Exits = new Location[] { 前陽台, 後陽台 };
            

        }

        private void 走去(Location 目的地)
        {
            currentLocation = 目的地;
            Exits.Items.Clear();
            foreach (Location location in currentLocation.Exits)
                Exits.Items.Add(location.Name);
            Exits.SelectedIndex = 0;
            description.Text = currentLocation.Description;
            
            //Door
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;

            //Stair
            if (currentLocation is IHasStairs)
                goThroughTheStair.Visible = true;
            else
                goThroughTheStair.Visible = false;

        }


        private void goHere_Click(object sender, EventArgs e)
        {
            走去(currentLocation.Exits[Exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor 有對外門的區域 = currentLocation as IHasExteriorDoor;
            走去(有對外門的區域.DoorLocation);
        }

        private void goThroughTheStair_Click(object sender, EventArgs e)
        {
            IHasStairs 有樓梯的區域 = currentLocation as IHasStairs;
            走去(有樓梯的區域.StairLocation);
        }
        
    }
}
