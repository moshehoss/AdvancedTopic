/*PRACTICE 1*/
function getCurrencyRate(cb) {
  setTimeout(() => {
    cb(4);
  }, 1500);
}
getCurrencyRate((num) => {
  console.log(num);
});
/*PRACTICE 2*/
function showFileData(filename, cb) {
  setTimeout(() => {
    cb(filename);
  }, 3000);
}
showFileData("my_file.txt", (filename) => {
  console.log(`This is from ${filename}`);
});
