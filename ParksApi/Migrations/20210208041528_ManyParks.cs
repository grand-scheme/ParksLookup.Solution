using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class ManyParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Rickwood Caverns", "Alabama", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Cathedral Caverns", "Alabama", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Gulf", "Alabama", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Denali", "Alaska", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                columns: new[] { "Name", "State" },
                values: new object[] { "Kachemak", "Alaska" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 137, "Sterling Forest", "New York", "State" },
                    { 138, "Chimney Rock", "North Carolina", "State" },
                    { 139, "Fort Macon", "North Carolina", "State" },
                    { 140, "Hanging Rock", "North Carolina", "State" },
                    { 141, "Great Smoky Mountains", "North Carolina, Tennessee", "National" },
                    { 142, "Fort Abraham Lincoln", "North Dakota", "State" },
                    { 143, "Little Missouri", "North Dakota", "State" },
                    { 144, "Lake Metigoshe", "North Dakota", "State" },
                    { 145, "Theodore Roosevelt", "North Dakota", "National" },
                    { 146, "Hocking Hills", "Ohio", "State" },
                    { 147, "Salt Fork", "Ohio", "State" },
                    { 149, "Cuyahoga Valley", "Ohio", "National" },
                    { 136, "Niagara Falls", "New York", "State" },
                    { 150, "Beavers Bend", "Oklahoma", "State" },
                    { 151, "Lake Thunderbird", "Oklahoma", "State" },
                    { 152, "Robbers Cave", "Oklahoma", "State" },
                    { 153, "Ecola", "Oregon", "State" },
                    { 154, "Milo McIver", "Oregon", "State" },
                    { 155, "Smith Rock", "Oregon", "State" },
                    { 156, "Crater Lake", "Oregon", "National" },
                    { 157, "Cherry Springs", "Pennsylvania", "State" },
                    { 158, "Cook Forest", "Pennsylvania", "State" },
                    { 148, "Punderson", "Ohio", "State" },
                    { 135, "Adirondack", "New York", "State" },
                    { 133, "Carlsbad Caverns", "New Mexico", "National" },
                    { 159, "Presque Isle", "Pennsylvania", "State" },
                    { 111, "Prairie", "Missouri", "State" },
                    { 112, "Gateway Arch", "Missouri", "National" },
                    { 113, "Makoshika", "Montana", "State" },
                    { 114, "Rosebud Battlefield", "Montana", "State" },
                    { 115, "Pictograph Cave", "Montana", "State" },
                    { 116, "Glacier", "Montana", "National" },
                    { 117, "Eugene T. Mahoney", "Nebraska", "State" },
                    { 118, "Fort Robinson", "Nebraska", "State" },
                    { 119, "Wildcat Hills", "Nebraska", "State" },
                    { 120, "Lake Tahoe", "Nevada", "State" },
                    { 134, "White Sands", "New Mexico", "National" },
                    { 121, "Valley of Fire", "Nevada", "State" },
                    { 123, "Great Basin", "Nevada", "National" },
                    { 124, "Crawford Notch", "New Hampshire", "State" },
                    { 125, "Franconia Notch", "New Hampshire", "State" },
                    { 126, "Bear Brook", "New Hampshire", "State" },
                    { 127, "Island Beach", "New Jersey", "State" },
                    { 128, "Liberty State Park", "New Jersey", "State" },
                    { 129, "Pigeon Swamp", "New Jersey", "State" },
                    { 130, "Bottomless Lakes", "New Mexico", "State" },
                    { 131, "City of Rocks", "New Mexico", "State" },
                    { 132, "Elephant Butte", "New Mexico", "State" },
                    { 122, "Cave Lake Slate", "Nevada", "State" },
                    { 160, "Beavertail", "Rhode Island", "State" },
                    { 163, "Hunting Island", "South Carolina", "State" },
                    { 162, "Colt", "Rhode Island", "State" },
                    { 190, "Smugglers’ Notch", "Vermont", "State" },
                    { 191, "Camel’s Hump", "Vermont", "State" },
                    { 192, "First Landing", "Virginia", "State" },
                    { 193, "Grayson Highlands", "Virginia", "State" },
                    { 194, "Shenandoah River", "Virginia", "State" },
                    { 195, "Shenandoah", "Virginia", "National" },
                    { 196, "Cape Disappointment", "Washington", "State" },
                    { 197, "Deception Pass", "Washington", "State" },
                    { 198, "Wallas Falls", "Washington", "State" },
                    { 199, "Mount Rainier", "Washington", "National" },
                    { 189, "Ricker Pond", "Vermont", "State" },
                    { 200, "North Cascades", "Washington", "National" },
                    { 202, "Blackwater Falls", "West Virginia", "State" },
                    { 203, "Watoga", "West Virginia", "State" },
                    { 204, "Babcock", "West Virginia", "State" },
                    { 205, "New River Gorge", "West Virginia", "National" },
                    { 206, "Devil’s Lake", "Wisconsin", "State" },
                    { 207, "Lakeshore", "Wisconsin", "State" },
                    { 208, "Peninsula", "Wisconsin", "State" },
                    { 209, "Glendo", "Wyoming", "State" },
                    { 210, "Seminoe", "Wyoming", "State" },
                    { 211, "Hot Springs", "Wyoming", "State" },
                    { 201, "Olympic", "Washington", "National" },
                    { 188, "Capitol Reef", "Utah", "National" },
                    { 187, "Canyonlands", "Utah", "National" },
                    { 186, "Bryce Canyon", "Utah", "National" },
                    { 110, "Knob Knoster", "Missouri", "State" },
                    { 164, "Mountain Bridge Wilderness Area", "South Carolina", "State" },
                    { 165, "Table Rock", "South Carolina", "State" },
                    { 166, "Congaree", "South Carolina", "National" },
                    { 167, "Custer", "South Dakota", "State" },
                    { 168, "Bear Butte", "South Dakota", "State" },
                    { 169, "Sica Hollow", "South Dakota", "State" },
                    { 170, "Badlands", "South Dakota", "National" },
                    { 171, "Wind Cave", "South Dakota", "National" },
                    { 172, "Fall Creek Falls", "Tennessee", "State" },
                    { 173, "South Cumberland", "Tennessee", "State" },
                    { 174, "Roan Mountain", "Tennessee", "State" },
                    { 175, "Big Bend Ranch", "Texas", "State" },
                    { 176, "Palo Duro Canyon", "Texas", "State" },
                    { 177, "Falcon", "Texas", "State" },
                    { 178, "Big Bend", "Texas", "National" },
                    { 179, "Guadalupe Mountains", "Texas", "National" },
                    { 180, "Virgin Islands", "U.S. Virgin Islands", "National" },
                    { 181, "Dead Horse Point", "Utah", "State" },
                    { 182, "Goblin Valley", "Utah", "State" },
                    { 183, "Jordanelle Reservoir", "Utah", "State" },
                    { 184, "Zion", "Utah", "National" },
                    { 185, "Arches", "Utah", "National" },
                    { 161, "Snake Den", "Rhode Island", "State" },
                    { 109, "Johnson’s Shut-Ins", "Missouri", "State" },
                    { 107, "Tishomingo", "Mississippi", "State" },
                    { 212, "Grand Teton", "Wyoming", "National" },
                    { 32, "Kings Canyon", "California", "National" },
                    { 33, "Lassen Volcanic", "California", "National" },
                    { 34, "Pinnacles", "California", "National" },
                    { 35, "Redwood", "California", "National" },
                    { 36, "Sequoia", "California", "National" },
                    { 37, "Death Valley", "California, Nevada", "National" },
                    { 38, "Mueller", "Colorado", "State" },
                    { 39, "State Forest", "Colorado", "State" },
                    { 40, "Fishers Peak", "Colorado", "State" },
                    { 41, "Black Canyon of the Gunnison", "Colorado", "National" },
                    { 31, "Joshua Tree", "California", "National" },
                    { 42, "Great Sand Dunes", "Colorado", "National" },
                    { 44, "Rocky Mountain", "Colorado", "National" },
                    { 45, "Dinosaur", "Connecticut", "State" },
                    { 46, "Kent Falls", "Connecticut", "State" },
                    { 47, "Rocky Neck", "Connecticut", "State" },
                    { 48, "Cape Henlopen", "Delaware", "State" },
                    { 49, "Trap Pond", "Delaware", "State" },
                    { 50, "Fort Delaware", "Delaware", "State" },
                    { 51, "Blue Spring", "Florida", "State" },
                    { 52, "Florida Caverns", "Florida", "State" },
                    { 53, "Fort De Soto", "Florida", "State" },
                    { 43, "Mesa Verde", "Colorado", "National" },
                    { 54, "Biscayne", "Florida", "National" },
                    { 30, "Channel Islands", "California", "National" },
                    { 28, "Julia Pfeiffer Burns", "California", "State" },
                    { 6, "Wood-Tikchik", "Alaska", "State" },
                    { 7, "Denali", "Alaska", "National" },
                    { 8, "Gates of the Arctic", "Alaska", "National" },
                    { 9, "Glacier Bay", "Alaska", "National" },
                    { 10, "Katmai", "Alaska", "National" },
                    { 11, "Kenai Fjords", "Alaska", "National" },
                    { 12, "Kobuk Valley", "Alaska", "National" },
                    { 13, "Lake Clark", "Alaska", "National" },
                    { 14, "Wrangell–St. Elias", "Alaska", "National" },
                    { 15, "American Samoa", "American Samoa", "National" },
                    { 29, "Yosemite", "California", "National" },
                    { 16, "Kartchner Caverns", "Arizona", "State" },
                    { 18, "Red Rock", "Arizona", "State" },
                    { 19, "Grand Canyon", "Arizona", "National" },
                    { 20, "Petrified Forest", "Arizona", "National" },
                    { 21, "Saguaro", "Arizona", "National" },
                    { 22, "Devil’s Den", "Arkansas", "State" },
                    { 23, "Bull Shoals-White River", "Arkansas", "State" },
                    { 24, "Cane Creek", "Arkansas", "State" },
                    { 25, "Hot Springs", "Arkansas", "National" },
                    { 26, "Crystal Cove", "California", "State" },
                    { 27, "Jedediah Smith Redwoods", "California", "State" },
                    { 17, "Slide Rock", "Arizona", "State" },
                    { 55, "Dry Tortugas", "Florida", "National" },
                    { 56, "Everglades", "Florida", "National" },
                    { 57, "Cloudland Canyon", "Georgia", "State" },
                    { 85, "Chicot", "Louisiana", "State" },
                    { 86, "Lake Fausse Pointe", "Louisiana", "State" },
                    { 87, "Fontainebleau", "Louisiana", "State" },
                    { 88, "Mt. Blue", "Maine", "State" },
                    { 89, "Quoddy Head", "Maine", "State" },
                    { 90, "Reid", "Maine", "State" },
                    { 91, "Acadia", "Maine", "National" },
                    { 92, "Assateague", "Maryland", "State" },
                    { 93, "Elk Neck", "Maryland", "State" },
                    { 94, "Point Lookout", "Maryland", "State" },
                    { 84, "Mammoth Cave", "Kentucky", "National" },
                    { 95, "Bash Bish Falls", "Massachusetts", "State" },
                    { 97, "Mount Greylock", "Massachusetts", "State" },
                    { 98, "Belle Isle", "Michigan", "State" },
                    { 99, "Laughing Whitefish Falls", "Michigan", "State" },
                    { 100, "Porcupine Mountains Wilderness", "Michigan", "State" },
                    { 101, "Isle Royale", "Michigan", "National" },
                    { 102, "George H. Crosby Manitou", "Minnesota", "State" },
                    { 103, "Itasca", "Minnesota", "State" },
                    { 104, "Minneopa", "Minnesota", "State" },
                    { 105, "Voyageurs", "Minnesota", "National" },
                    { 106, "LeFleur's Bluff", "Mississippi", "State" },
                    { 96, "Boston Harbor Islands", "Massachusetts", "State" },
                    { 83, "Natural Bridge", "Kentucky", "State" },
                    { 82, "Daniel Boone", "Kentucky", "State" },
                    { 81, "Cumberland Falls", "Kentucky", "State" },
                    { 58, "Fort Yargo", "Georgia", "State" },
                    { 59, "Tallulah Gorge", "Georgia", "State" },
                    { 60, "Akaka Falls", "Hawaii", "State" },
                    { 61, "Waiʻānapanapa", "Hawaii", "State" },
                    { 62, "Waimea Canyon", "Hawaii", "State" },
                    { 63, "Haleakalā", "Hawaii", "National" },
                    { 64, "Hawaiʻi Volcanoes", "Hawaii", "National" },
                    { 65, "Bruneau Dunes", "Idaho", "State" },
                    { 66, "Harriman", "Idaho", "State" },
                    { 67, "Priest Lake", "Idaho", "State" },
                    { 68, "Hennepin Canal Parkway", "Illinois", "State" },
                    { 69, "South Shore", "Illinois", "State" },
                    { 70, "Starved Rock", "Illinois", "State" },
                    { 71, "Brown County", "Indiana", "State" },
                    { 72, "Chain O’ Lakes", "Indiana", "State" },
                    { 73, "Turkey Run", "Indiana", "State" },
                    { 74, "Indiana Dunes", "Indiana", "National" },
                    { 75, "Backbone", "Iowa", "State" },
                    { 76, "Beed's Lake", "Iowa", "State" },
                    { 77, "Pikes Peak", "Iowa", "State" },
                    { 78, "Kanopolis", "Kansas", "State" },
                    { 79, "Scott", "Kansas", "State" },
                    { 80, "Wilson", "Kansas", "State" },
                    { 108, "Shepard State", "Mississippi", "State" },
                    { 213, "Yellowstone", "Wyoming, Montana, Idaho", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 213);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Mount Rainier", "Washington", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "North Cascades", "Washington", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Olympic", "Washington", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                columns: new[] { "Name", "State", "StateOrNational" },
                values: new object[] { "Crater Lake", "Oregon", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                columns: new[] { "Name", "State" },
                values: new object[] { "test2", "Oregon" });
        }
    }
}
