main();

async function main() {
  //ex1:
  try {
    let isOkText = await checkIfNumberOk(3);
    console.log(isOkText);
  } catch (error) {
    console.log(error);
  }

  //ex2:
  console.log(await myPromiseA());
  console.log(await myPromiseB());
  console.log(await myPromiseC());

  //ex3:
  fetch("https://jsonplaceholder.typicode.com/posts/1", {
    method: "GET",
  })
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      console.log(data.title);
    });

  //ex4:
  fetch("https://jsonplaceholder.typicode.com/posts/1", {
    method: "DELETE",
  })
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      data.title = "deleted successfel";
      console.log(data.title);
    });
}

function checkIfNumberOk(num) {
  let pro = new Promise((resolve, reject) => {
    setTimeout(() => {
      if (num > 10) resolve("number is ok");
      else reject("bad number");
    }, 3000);
  });
  return pro;
}

function myPromiseA() {
  let promise = new Promise(function (resolve, reject) {
    resolve("promise 1 is solved");
  });

  return promise;
}

function myPromiseB() {
  let promise = new Promise(function (resolve, reject) {
    resolve("promise 2 is solved");
  });

  return promise;
}

function myPromiseC() {
  let promise = new Promise(function (resolve, reject) {
    resolve("promise 3 is solved");
  });

  return promise;
}
