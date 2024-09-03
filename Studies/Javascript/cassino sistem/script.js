const prompt = require("prompt-sync")();

const deposit = () => {
  while (true) {
  const depositAmout = prompt("Enter a deposit amount: ");
    const nDA = parseFloat(depositAmout);

    if (isNaN(nDA) || nDA <= 0) {
      console.log('invalid deposit amout, try again.');
    } else {
      return nDA;
    }
  }
}

const getnof = () => {
  while (true) {
    const lines = prompt("Enter the nunber of lines to be on (1-3): ");
      const nofline = parseFloat(lines);
  
      if (isNaN(nofline) || nofline <= 0 || nofline > 3) {
        console.log('invalid number of lines, try again');
      } else {
        return nofline;
      }
    }
}

const depositAmout = deposit()
const nofline = getnof()