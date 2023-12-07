const APIKey = "97eef44b071a48cd9b0122754232711";
let cities = ["London", "Tel Aviv", "Jerusalem", "Jersey City", "Kefar Yona"];
var APILink;

async function getWeatherASync(i) {
  APILink = `http://api.weatherapi.com/v1/current.json?key=97eef44b071a48cd9b0122754232711&q=${cities[i]}&aqi=no`;
  let data = await fetch(APILink);
  let jsonData = await data.json();
  let location = jsonData["location"];
  let dataArr = Object.entries(location);
  console.log(dataArr);
  document.getElementById(`${i}`).innerText =
    dataArr[0][0] +
    ": " +
    dataArr[0][1] +
    "\n" +
    dataArr[1][0] +
    ": " +
    dataArr[1][1] +
    "\n" +
    dataArr[7][0] +
    ": " +
    dataArr[7][1] +
    "\n\n\n";
  i += 1;
  if (i == 5) i = 0;
}
function getWeather() {
  let i = 0;

  APILink = `http://api.weatherapi.com/v1/current.json?key=97eef44b071a48cd9b0122754232711&q=${cities[i]}&aqi=no`;
  fetch(APILink)
    .then((data) => {
      return data.json();
    })
    .then((jsonData) => {
      let location = jsonData["location"];
      let dataArr = Object.entries(location);
      console.log(dataArr);
      document.getElementById(`${i}`).innerText =
        dataArr[0][0] +
        ": " +
        dataArr[0][1] +
        "\n" +
        dataArr[1][0] +
        ": " +
        dataArr[1][1] +
        "\n" +
        dataArr[7][0] +
        ": " +
        dataArr[7][1] +
        "\n\n\n";
    })
    .catch((error) => {
      console.log(error);
    });
  i += 1;
  i == 5 ? (i = -1) : (i = i);
}
/*var i = 0;
setInterval(() => {
  console.log(i);
  getWeatherASync(i);
  i += 1;
  if (i == 5) {
    i = 0;
  }
}, 3000);*/
async function getPikudData() {
  let apilink2 = "https://reqbin.com/echo/get/json";
  let apilink1 = "https://www.oref.org.il//12481-en/Pakar.aspx";
  const response = await fetch(apilink1);

  const json = await response.json();

  console.log(JSON.stringify(json));
}
/*setInterval(()=> {

},3000);*/
getPikudData();
