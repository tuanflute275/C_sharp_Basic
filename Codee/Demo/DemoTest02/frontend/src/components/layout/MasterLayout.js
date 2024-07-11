import React from 'react'
import Header from './header/Header'

function MasterLayout({ child }) {
    return (
        <>
            <Header />
            {child}
        </>
    )
}

export default MasterLayout