import { useState, useEffect } from 'react'

function Clock(props) {
  const [date, setDate] = useState(new Date())
    const [timeInWords, setTimeInWords] = useState(timeToWords(new Date()));

    function timeToWords(date) {
        const hours = date.getHours();
        const minutes = date.getMinutes();

        const numbersToWords = {
            0: 'cero', 1: 'one', 2: 'two', 3: 'three', 4: 'four',
            5: 'five', 6: 'six', 7: 'seven', 8: 'eight', 9: 'nine',
            10: 'ten', 11: 'eleven', 12: 'twelve', 
            13: 'thirteen', 14: 'fourteen', 15: 'fifteen',
            16: 'sixteen', 17: 'seventeen', 18: 'eighteen',
            19: 'nineteen', 20: 'twenty', 21: 'twenty one',
            22: 'twenty two', 23: 'twenty three', 24: 'twenty four',
            25: 'twenty five', 26: 'twenty six', 27: 'twenty seven',
            28: 'twenty eight', 29: 'twenty nine', 30: 'thirty',
            31: 'thirty one', 32: 'thirty two', 33: 'thirty three',
            34: 'thirty four', 35: 'thirty five', 36: 'thirty six',
            37: 'thirty seven', 38: 'thirty eight', 39: 'thirty nine',
            40: 'forty', 41: 'forty one', 42: 'forty two', 43: 'forty three',
            44: 'forty four', 45: 'forty five', 46: 'forty six', 47: 'forty seven',
            48: 'forty eight', 49: 'forty nine', 50: 'fifty', 51: 'fifty one',
            52: 'fifty two', 53: 'fifty three', 54: 'fifty four', 55: 'fifty five',
            56: 'fifty six', 57: 'fifty seven', 58: 'fifty eight', 59: 'fifty nine',
            60: 'sixty'
        };

        let hourWord = numbersToWords[hours % 12] || numbersToWords[12];
        let minuteWord = (minutes === 0) ? "o'clock" : (minutes < 10 ? 'oh ' + numbersToWords[minutes] : numbersToWords[minutes]);
        let amPm = hours >= 12 ? 'PM' : 'AM';

        return `${hourWord} ${minuteWord} ${amPm}`;
    }

  function refreshClock() {
      const newDate = new Date();
      setDate(newDate);
      setTimeInWords(timeToWords(newDate));

  }

  useEffect(() => {
    const timerId = setInterval(refreshClock, 1000)
    return function cleanup() {
      clearInterval(timerId)
    }
  }, [])

  let displayText = date.toLocaleTimeString()
  if (props.clockProps.blinkColons & (date.getSeconds() % 2 === 0)) {
    displayText = displayText.replace(/:/g, ' ')
  }

  let displayStyle = {
    fontFamily: props.clockProps.fontFamily,
    color: props.clockProps.fontColor,
  }

  let titleStyle = {
    fontSize: `${props.clockProps.titleFontSize}pt`,
  }

  let clockStyle = {
    fontSize: `${props.clockProps.clockFontSize}pt`,
  }

    return (
        <div id="Clock" className="text-center w-full border border-small align-center justify-center">
          <div id="Digits" style={displayStyle}>
            <div id="title" style={titleStyle}>
              The Time of Your Life
            </div>
            <div id="time" style={clockStyle}>
              {displayText}
                </div>
                <div id="words" style={clockStyle}>
                    {timeInWords}
                </div>
          </div>
        </div>
     );
}

export default Clock
