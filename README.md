![logo](https://raw.githubusercontent.com/dt-win/RDPoverSSH/main/RDPoverSSH/Images/logo.png)


# RDPoverSSH

A peer-to-peer Windows Remote Desktop solution using SSH.

## About

RDPoverSSH uses SSH tunnels with certificate authentication to map a port on the local machine to any port on the remote machine. It is specifically designed for remote control with Microsoft's Remote Desktop Protocol, although any port mapping may be configured.

It is especially useful in an environment where the target machine is behind a NAT router or firewall that is under someone else's control. Using reverse SSH tunnels, the target machine can initiate the connection outwards. Once the tunnel is open and a port is mapped to the target machine, it is available to receive connections without any port forwarding required on the target side.

For some background on how reverse SSH tunnels work, check out the several great answers on this StackOverflow question. https://unix.stackexchange.com/questions/46235/how-does-reverse-ssh-tunneling-work

> Note that either direct WAN access or router port forwarding is required on at least one side of the connection. RDPoverSSH will not work if the tunnel target's port is not publicly accessible.

## Download

Download the latest release [here](https://github.com/dt-win/RDPoverSSH/releases/latest).

## How to Use

See the [wiki](https://github.com/dt-win/RDPoverSSH/wiki) for full instructions.

## Screenshots

### RDP over Normal Tunnel

#### Connection Source

![image](https://github-production-user-asset-6210df.s3.amazonaws.com/7417301/240734643-6e7f7f96-6514-4183-8bce-f02f6a339db3.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240814%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240814T015754Z&X-Amz-Expires=300&X-Amz-Signature=cba0d2ef1550b2378f5e4b61b013f6ae3ddc50903bf1ce77857b1d1fddeca222&X-Amz-SignedHeaders=host&actor_id=99040765&key_id=0&repo_id=429996846)

#### Connection Target

![image](https://github-production-user-asset-6210df.s3.amazonaws.com/7417301/240734757-08ca77a8-f495-47de-8c71-e1d65efb3f9b.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240814%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240814T015905Z&X-Amz-Expires=300&X-Amz-Signature=d41426fcf990e8ca7229b92cbbf111b59a11b637ff02cb8e12e55c59fb55f89a&X-Amz-SignedHeaders=host&actor_id=99040765&key_id=0&repo_id=429996846)

### RDP over Reverse Tunnel

#### Connection Source

![image](https://github-production-user-asset-6210df.s3.amazonaws.com/7417301/240734892-10b5cf31-5cbb-4212-a245-fd0f5f4758d3.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240814%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240814T015929Z&X-Amz-Expires=300&X-Amz-Signature=a00a7ad61e78230c0d909c2ddf39c6103461efb5ffa1533bdee6d2f805fab1d5&X-Amz-SignedHeaders=host&actor_id=99040765&key_id=0&repo_id=429996846)

#### Connection Target

![image](https://github-production-user-asset-6210df.s3.amazonaws.com/7417301/240735591-f28a343a-d8fd-4068-805d-ed517815d4e0.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240814%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240814T015952Z&X-Amz-Expires=300&X-Amz-Signature=926c241c248e04378f2882822ab30476a7274dd3c1ceb2c99a8fa2592053e201&X-Amz-SignedHeaders=host&actor_id=99040765&key_id=0&repo_id=429996846)

### Condensed UI

![image](https://github-production-user-asset-6210df.s3.amazonaws.com/7417301/240735591-f28a343a-d8fd-4068-805d-ed517815d4e0.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240814%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240814T015952Z&X-Amz-Expires=300&X-Amz-Signature=926c241c248e04378f2882822ab30476a7274dd3c1ceb2c99a8fa2592053e201&X-Amz-SignedHeaders=host&actor_id=99040765&key_id=0&repo_id=429996846)

### Dark Mode

![image](https://github-production-user-asset-6210df.s3.amazonaws.com/7417301/240735762-8556ed36-e374-41fb-9f3c-45ad717513a9.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240814%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240814T020127Z&X-Amz-Expires=300&X-Amz-Signature=bde555a31c26cec06ac6c44801f48c599f9908c6ddbf43fd1d4f405d7d925ef3&X-Amz-SignedHeaders=host&actor_id=99040765&key_id=0&repo_id=429996846)

## Requirements

Requires Windows 10 or later.

# Attribution
[Icon](https://www.flaticon.com/premium-icon/data-transfer_2985993) made by [Prosymbols Premium](https://www.flaticon.com/authors/prosymbols-premium) from [www.flaticon.com](https://www.flaticon.com/).
