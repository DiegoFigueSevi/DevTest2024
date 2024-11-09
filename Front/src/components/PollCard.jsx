import React from 'react'
import ItemPoll from './ItemPoll'

const PollCard = ({response}) => {

    const {id, name, options} = response

    const getTotalVotes = () => {
        let votes = 0
        for (let i = 0; i < options.length; i++){
          votes += options[i].votes
        
        }
        return votes
    }

  return (
    <div className='bg-white p-3 rounded-md flex flex-col gap-2 md:p-7' >
      <h1 className='font-bold text-lg'>{name}</h1>
      <div className='flex flex-col gap-2'>
        {options.map((e) => <ItemPoll option={e} totalVotes={getTotalVotes()}/>)}
      </div>
      <p className='md:text-end text-start'>{`${getTotalVotes()} votes`}</p>
    </div>
  )
}

export default PollCard
