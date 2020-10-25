FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN useradd -m -s $(which bash) mahi
# Option '-m' to create home directory see https://askubuntu.com/a/393470
# How to set bash as shell, see comments in the same answer

# Create working directory and change ownership.
# Ownership will be preserved when mounting volume to /app
# See https://stackoverflow.com/a/56990338/411428
# and https://github.com/docker/compose/issues/3270#issuecomment-543603959
RUN mkdir /app && chown mahi:mahi /app

USER mahi
