import React, { useEffect, useState } from 'react'

const ItemPoll = ({option, totalVotes}) => {

  const [percentage, setPercentage] = useState(0.0)

    const {name, votes} = option
    const getPercent = () => {
      
        return (option.votes / totalVotes) * 100
    }

    useEffect(() => {
      setPercentage(getPercent())
    }, [])
    

  return (
    <div className='bg-gray-200 p-2 flex flex-col gap-1 md:p-5'>
      <div className='flex items-center justify-between'>
        <h1>{name}</h1>
        <p>{`${percentage.toFixed()}%`}</p>
      </div>
      <div className='bg-red-50 h-2 rounded-full'>
        <div  className={`bg-red-500 w-[${percentage.toFixed()}%] h-2 rounded-full`}/>
      </div>
    </div>
  )
}

export default ItemPoll
