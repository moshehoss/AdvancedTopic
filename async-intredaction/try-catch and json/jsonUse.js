function readingData() {
  fetch("https://jsonplaceholder.typicode.com/posts/1/comments")
    .then((resp) => {
      return resp.json();
    })
    .then((data) => {
      setData(data);
    });
}

function setData(data) {
  let str = "";
  for (let i = 0; i < data.length; i++) {
    str += `<p> ${data[i].id} 
    name: ${data[i].name}
    email: ${data[i].email}</p>`;
  }
  document.getElementById("comments").innerHTML = str;
}

function Main() {
  let time = 0;
  setInterval(() => {
    readingData();
    time += 3;
    if (time >= 10) {
      document.getElementById("update").innerText = `9:${time}`;
    } else {
      document.getElementById("update").innerText = `9:0${time}`;
    }
  }, 3000);
}

Main();
