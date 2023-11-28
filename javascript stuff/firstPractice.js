function print(num) {
  setTimeout(() => {
    console.log(`I ran after ${num} seconds`);
  }, num * 1000);
}
print(4);

