import Clock from './components/Clock.js'
import SetClockProps from './components/SetClockProps.js'
import ClockProps from './components/ClockProps.js'
import './components/App.css'
import { useState } from 'react'

function App() {
  const [clockProps, setClockProps] = useState(new ClockProps())
  return (
      <div className="p-2 flex flex-column flex-1">
        <Clock clockProps={clockProps} />
        <SetClockProps setClockProps={setClockProps} />
    </div>
  )
}

export default App
