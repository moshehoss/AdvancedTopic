/*PRACTICE 1*/
function checkIfNumberOK(num) {
  return new Promise((resolve, reject) => {
    if (num < 10) {
      setTimeout(() => {
        reject("Bad number");
      }, 3000);
    } else {
      setTimeout(() => {
        resolve("Number is OK");
      }, 3000);
    }
  });
}
async function getNumberResult() {
  let goodNum = 14,
    badNum = 5;
  try {
    let result1 = await checkIfNumberOK(goodNum);
    console.log(result1);
  } catch (error) {
    console.log(error);
  }

  try {
    let result2 = await checkIfNumberOK(badNum);
    console.log(result2);
  } catch (error) {
    console.log(error);
  }
}
getNumberResult();
/*PRACTICE 2*/
function myPromiseA() {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("promise a resolved");
    }, 1000);
  });
}
function myPromiseB() {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("promise b resolved");
    }, 1000);
  });
}
function myPromiseC() {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("promise c resolved");
    }, 1000);
  });
}
async function resolvePromises() {
  try {
    let a = await myPromiseA();
    console.log(a);
    let b = await myPromiseB();
    console.log(b);
    let c = await myPromiseC();
    console.log(c);
  } catch (error) {
    console.log(error);
  }
}
resolvePromises();
