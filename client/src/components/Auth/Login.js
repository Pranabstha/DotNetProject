import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import axios from 'axios'; // Import Axios

const Login = () => {
    const [formData, setFormData] = useState({ userName: '', password: '' });
    const [error, setError] = useState('');
    const [showPassword, setShowPassword] = useState(false); // State to manage password visibility
    const navigate = useNavigate();

    const handleChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    const togglePasswordVisibility = () => {
        setShowPassword(!showPassword);
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        try {
            const response = await axios.post('/api/user-authentication/login', formData);

            if (response.data.token) {
                // Reset form data
                setFormData({ userName: '', password: '' });

                // Redirect to the home page or any other page upon successful login
                navigate('/');
            } else {
                throw new Error('Login failed');
            }
        } catch (error) {
            setError('Login failed. Please check your username and password.');
        }
    };

    return (
        <div className="auth-container">
            <h2>Login</h2>
            {error && <div className="alert alert-danger">{error}</div>}
            <form onSubmit={handleSubmit} className="d-flex flex-column gap-4">
                <div>
                    <label>Username:</label>
                    <input
                        type="text"
                        name="userName"
                        value={formData.userName}
                        onChange={handleChange}
                    />
                </div>
                <div>
                    <label>Password:</label>
                    <div className="password-input position-relative">
                        <input
                            type={showPassword ? 'text' : 'password'}
                            name="password"
                            value={formData.password}
                            onChange={handleChange}
                        />
                        <i
                            className={`password-toggle-icon ${showPassword ? 'fas fa-eye-slash' : 'fas fa-eye'}`}
                            onClick={togglePasswordVisibility}
                            style={{ cursor: 'pointer' }} // Change cursor to pointer on hover
                        />
                    </div>
                </div>
                <button type="submit" className="btn btn-primary py-3">Login</button>
            </form>
        </div>
    );
};

export default Login;
