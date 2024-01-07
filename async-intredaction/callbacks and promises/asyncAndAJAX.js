//ex1
function checkIfNumberOk(num) {
  let myPromise = new Promise((resolve, reject) => {
    setTimeout(() => {
      if (num > 10) {
        resolve("number is ok.");
      } else {
        reject("bad number");
      }
    }, 2000);
  });
  return myPromise;
}

async function callNumCheck() {
  try {
    let result = await checkIfNumberOk(16);
    console.log(result);
  } catch (error) {
    console.log(error);
  }
}

// callNumCheck();

//ex2
function myPromiseA() {
  let promise = new Promise((resolve, reject) => {
    resolve("promise 1 resoved");
  });
  return promise;
}
function myPromiseB() {
  let promise = new Promise((resolve, reject) => {
    resolve("promise 2 resoved");
  });
  return promise;
}
function myPromiseC() {
  let promise = new Promise((resolve, reject) => {
    resolve("promise 3 resoved");
  });
  return promise;
}

async function ThreePromises() {
  let pArr = await Promise.all([myPromiseA(), myPromiseB(), myPromiseC()]);
  console.log(pArr);
}

// ThreePromises();

//APAX
//ex1
function GetTitle() {
  fetch("http://jsonplaceholder.typicode.com/posts/1", {
    method: "GET",
  })
    .then((res) => {
      return res.json();
    })
    .then((jsonObj) => {
      console.log(jsonObj.title);
    });
}
// GetTitle();
//ex1
function DeleteTitle() {
  fetch("http://jsonplaceholder.typicode.com/posts/1", {
    method: "DELETE",
  })
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      data.title = "success";
      console.log(data.title);
    });
}
// DeleteTitle();
