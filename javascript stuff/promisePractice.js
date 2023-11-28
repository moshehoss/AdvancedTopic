/*PRACTICE 3+4*/
function isBehindUs() {
  let myPromise = new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("The majority is behind us");
    }, 2000);
  });
  return myPromise;
}
isBehindUs().then((data) => {
  console.log(data);
});
/*PRACTICE 5*/
function checkIfNumberOK(num) {
  let myPromise = new Promise((resolve, reject) => {
    if (num > 10) resolve("OK");
    else reject("Number bad");
  });
  return myPromise;
}
checkIfNumberOK(7)
  .then((data) => {
    console.log(data);
  })
  .catch((err) => {
    console.log(err);
  });
