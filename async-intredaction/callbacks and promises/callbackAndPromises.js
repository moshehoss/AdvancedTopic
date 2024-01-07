//callbacks
//ex1
// function getCurrencyRate(cb) {
//   setTimeout(() => {
//     cb(4);
//   }, 1000);
// }

// getCurrencyRate((answer) => {
//   console.log(answer);
// });

//ex2
// function getDataFromHardDisk(fileName, cb) {
//   setTimeout(() => {
//     cb(`this file is from fileName: ${fileName}`);
//   }, 1000);
// }

// getDataFromHardDisk("shahar", (answer) => {
//   console.log(answer);
// });

// promises
//ex1
// function getMessageMajority() {
//   let myPromise = new Promise((resolve, reject) => {
//     setTimeout(() => {
//       resolve("the majority is behind us");
//     }, 2000);
//   });
//   return myPromise;
// }

// getMessageMajority().then((message) => {
//   console.log(message);
// });

//grouping promises
//ex1
// function getMessageTimePass() {
//   let myPromise = new Promise((resolve, reject) => {
//     setTimeout(() => {
//       resolve("two seconds pass.");
//     }, 2000);
//   });
//   return myPromise;
// }

// getMessageTimePass().then((message) => {
//   console.log(message);
// });

//ex2
// function checkIfNumberOk(num) {
//   let myPromise = new Promise((resolve, reject) => {
//     setTimeout(() => {
//       if (num > 10) {
//         resolve("number is ok.");
//       } else {
//         reject("bad number");
//       }
//     }, 2000);
//   });
//   return myPromise;
// }

// checkIfNumberOk(2).then((message) => {
//   console.log(message);
// });
