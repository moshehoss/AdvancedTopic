loadFunction();

function loadFunction() {
  // ex1:
  getCurrentlyRate((n)=>{
      console.log(n);
  });
  // ex2:
  let fileName = callHardDisk("CHECKIN", (fileName) => {
      return `This is from ${fileName}`;
  });
  console.log(fileName);
  // ex3:
  newPromiseMajor().then((text)=>{console.log(text);});
  // ex4:
    twoSecPassed().then((data=>{console.log(data);}));
  //ex5:
    checkIfNumberOk(77)
      .then((data) => console.log(data))
      .catch((err) => {
        console.log(err);
      });
}

function newPromiseMajor() {
  let pro = new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("the majority is behind us");
    }, 2000);
  });

  return pro;
}

function twoSecPassed() {
  let pro = new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("2 sec passed");
    }, 2000);
  });

  return pro;
}

function checkIfNumberOk(num) {
  let pro = new Promise((resolve, reject) => {
    if (num > 10) {
      resolve("Number Ok");
    } else {
      reject("bad number");
    }
  });

  return pro;
}

function callHardDisk(fileName, cb) {
  return cb(fileName);
}

function getCurrentlyRate(cb) {
  setTimeout(() => {
    cb(4);
  }, 1000);
}
