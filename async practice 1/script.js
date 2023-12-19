let text;
let isFirst = true;
loadFunction();

function loadFunction() {
  setInterval(() => {
    fetch(
      "https://api.tomorrow.io/v4/weather/forecast?location=42.3478,-71.0466&apikey=fzhS3RskICdqjBpy8kn7vtwLgUkUUm7t")
      .then((res) => {
        //פותח מעטפת1
        return res.json();
      })
      .then((data) => setIn(data));
  }, 3000);

  let sum = getSumOfNumbers(1, 2);

  try {
      getNumb(-8);
  } catch(error) {
      getNumb(0);
  }
}

function getNumb(num) {
  if (num < 0) {
    const err = new Error("num is negative");
    throw err;
  } else {
    console.log(`work with ${num} :))`);
  }
}

function getSumOfNumbers(num1, num2) {
  if (typeof num1 == "number" && typeof num2 == "number") {
    return num1 + num2;
  } else {
    const err = new Error("num1 or num 2 is not a number");
    throw err;
  }
}

function setIn(data) {
  text = data;
  let sentJson1 = `type: ${text.type}`;
  document.getElementById("info-json1").innerHTML = sentJson1;
  let sentJson2 = `updated: ${Date()}`;
  document.getElementById("info-json2").innerHTML = sentJson2;
}

function changeInfoShown(event) {
  if (isFirst) {
  }
}
function timeOut(input) {
  let t = setTimeout(() => {
    console.log(`רצתי לאחר ${input} שניות`);
    clearTimeout(t);
  }, input * 1000);
}
