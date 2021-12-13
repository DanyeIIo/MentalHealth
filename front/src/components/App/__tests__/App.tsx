import React from 'react'
import { render } from '@testing-library/react'
import App from '../App'

describe('rendering App', () => {

    test('check text', () => {
        render(<App />)
    })
})