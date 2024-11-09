import React, { useEffect, useState } from 'react'

const useFetch = (url) => {
  
    const [state, setState] = useState({
        data: null,
        isLoading: true,
        hasError: false,
        errorMessage: null
    })

    useEffect(() => {
      getFetch();
    }, [url])
    
    const getFetch = async () => {
        const response = await fetch(url)
        if(!response.ok){
            setState({
                data:null,
                isLoading:false,
                hasError:true,
                errorMessage: {
                    code: response.status,
                }
            })
            return;
        }
        const data = await response.json()
        setState({
            data: data,
            isLoading: false,
            hasError: false,
            errorMessage: null
        })
    }

    return {
        data: state.data,
        isLoading: state.isLoading,
        hasError: state.hasError,
    }
}

export default useFetch
