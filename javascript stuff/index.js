const APIKey = "97eef44b071a48cd9b0122754232711";
let cities = ["London", "Tel Aviv", "Jerusalem", "Jersey City", "Manhattan"];
let APILink;
async function getWeather() {
  for (let i = 0; i < 5; i++) {
    APILink = `http://api.weatherapi.com/v1/current.json?key=97eef44b071a48cd9b0122754232711&q=${cities[i]}&aqi=no`;
    let data = await fetch(APILink);
    let jsonData = await data.json();
    let location = jsonData["location"];
    let dataArr = Object.entries(location);
    console.log(dataArr);
    document.getElementById(`${i + 1}`).innerText =
      dataArr[0][0] +
      ": " +
      dataArr[0][1] +
      "\n" +
      dataArr[1][0] +
      ": " +
      dataArr[1][1] +
      "\n" +
      dataArr[2][0] +
      ": " +
      dataArr[2][1] +
      "\n\n\n";
  }
}

getWeather();
