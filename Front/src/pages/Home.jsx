import React, { useState } from 'react'
import { FaPlus } from "react-icons/fa6";
import PollCard from '../components/PollCard';
import useFetch from '../hooks/useFetch';
import FormModal from '../components/FormModal';
import { Link } from 'react-router-dom';

const Home = () => {

    const {data, isLoading} = useFetch('http://localhost:5029/api/Poll')    
    const [isModalOpen, setIsModalOpen] = useState(false)

  return (
    <div className='bg-sky-100 h-screen md:px-96'>
        <div className='px-6 '>

            <div className='flex items-center justify-between pt-5 mb-4'>
                <h1 className='text-gray-400 font-bold'>POLL LIST</h1>
                <Link to={'/create'}>
                    <div onClick={() => setIsModalOpen(true)} className='flex text-gray-400 font-bold gap-3'>
                        <h1 className='hidden md:block'>ADD NEW</h1>
                        <div className='bg-teal-400 p-1 rounded-full'>
                            <FaPlus className='text-white'/>
                        </div>
                    </div>
                </Link>
            </div>

            <div className='flex flex-col gap-3'>
                {!isLoading && data.map((e) => <PollCard key={e.id} response={e} />)}
            </div>
            
        </div>



    </div>
  )
}

export default Home
